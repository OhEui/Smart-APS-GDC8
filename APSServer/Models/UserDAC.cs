using APSVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSServer.Models
{
    public class UserDAC : IDisposable
    {
        SqlConnection conn = null;

        public UserDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn = null;
            }
        }

        public UserLogin Login(string id, string password)
        {
            string sql = @"
select u.User_NO, u.User_ID, u.User_Name, u.Dept_ID, d.Dept_Name
from UserInfo u left outer join Department d on u.Dept_ID = d.Dept_ID
where u.User_ID = @ID and u.User_PWD = @Password and u.Deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<UserLogin>(reader)?.FirstOrDefault();
                }
            }

        }


        // public WebMessage Logout(UserLogin data);

        public bool CheckID(string id)
        {
            string sql = @"select User_ID from UserInfo where User_ID = @ID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                int iResult = cmd.ExecuteNonQuery();
                return (iResult > 0);
            }
        }

        public bool CheckEmail(string email)
        {
            string sql = @"select User_Email from UserInfo where User_Email = @Email and Deleted=0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                int iResult = cmd.ExecuteNonQuery();
                return (iResult > 0);

            }
        }

        public WebMessage SignUp(UserInfo info)
        {
            WebMessage msg = new WebMessage();
            string sql = @"
insert into UserInfo (User_ID, User_Name, User_PWD, User_Email, User_phone, User_Birth, Dept_ID) 
values (@User_ID, @User_Name, @User_PWD, @User_Email, @User_phone, @User_Birth, @Dept_ID)";

            // 유효성 체크
            if (info.User_PWD != info.User_PWD_Repeat)
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "비밀번호 확인이 일치하지 않습니다.";
                return msg;
            }

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@User_ID", info.User_ID);
                cmd.Parameters.AddWithValue("@User_Name", info.User_Name);
                cmd.Parameters.AddWithValue("@User_PWD", info.User_PWD);
                cmd.Parameters.AddWithValue("@User_Email", info.User_Email);
                cmd.Parameters.AddWithValue("@User_phone", info.User_phone);
                cmd.Parameters.AddWithValue("@User_Birth", info.User_Birth);
                cmd.Parameters.AddWithValue("@Dept_ID", info.Dept_ID);

                int iResult = cmd.ExecuteNonQuery();
                if (iResult > 0)
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "회원가입을 성공하였습니다.";
                }
                else
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "회원가입 중 오류가 발생하였습니다.";
                }
            }
            return msg;
        }

        public WebMessage ResetPasswort(string id, string email)
        {
            // 임시비밀번호 생성 -> DB에 저장 -> 이메일 전송
            // DAC: DB에 저장
            // API: 임시 비밀번호 생성 -> DAC 호출 -> 이메일 전송

            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "임시비밀번호를 계정과 연결된 이메일로 전송하였습니다."
            };
        }

        public WebMessage<UserLogin> UpdateUserInfo(string curId, string curPassword, UserInfo newInfo)
        {
            // 현재 아이디, 비밀번호 확인 -> 정보 수정

            WebMessage<UserLogin> msg = new WebMessage<UserLogin>();

            string sql = @"
update UserInfo SET User_Name=@User_Name, User_PWD=@User_PWD, User_Email=@User_Email, 
User_phone=@User_phone, User_Birth=@User_Birth, Dept_ID=@Dept_ID
where User_ID=@Cur_ID and User_PWD=@Cur_PWD";

            if (!string.IsNullOrWhiteSpace(newInfo.User_PWD) && newInfo.User_PWD != newInfo.User_PWD_Repeat)
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "비밀번호 확인이 일치하지 않습니다.";
                return msg;
            }

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Cur_ID", curId);
                cmd.Parameters.AddWithValue("@Cur_PWD", curPassword);

                cmd.Parameters.AddWithValue("@User_Name", newInfo.User_Name);
                cmd.Parameters.AddWithValue("@User_PWD", newInfo.User_PWD);
                cmd.Parameters.AddWithValue("@User_Email", newInfo.User_Email);
                cmd.Parameters.AddWithValue("@User_phone", newInfo.User_phone);
                cmd.Parameters.AddWithValue("@User_Birth", newInfo.User_Birth);
                cmd.Parameters.AddWithValue("@Dept_ID", newInfo.Dept_ID);

                int iResult = cmd.ExecuteNonQuery();
                if (iResult > 0)
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "회원정보를 수정하였습니다.";
                    msg.Data = new UserLogin()
                    {
                    };
                }
                else
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "회원정보 수정 중 오류가 발생하였습니다.";
                    msg.Data = null;
                }
            }
            return msg;
        }

        public WebMessage WithDraw(string id, string password)
        {
            WebMessage msg = new WebMessage();

            string sql = @"
update UserInfo Set Deleted=1 where User_ID=@ID and User_PWD=@Password";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Password", password);

                int iResult = cmd.ExecuteNonQuery();
                if (iResult > 0)
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "회원탈퇴를 하였습니다.";
                }
                else
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "회원탈퇴 중 오류가 발생하였습니다.";
                }
            }
            return msg;
        }
    }
}