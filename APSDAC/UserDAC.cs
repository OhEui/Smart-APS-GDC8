using APSServer;
using APSVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSDAC
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
        /*
         UserLogin: 유저가 로그인하는동안 유지되는 정보
         UserInfo: 유저의 계정 정보

            winform 구현 우선순위
          1순위 Login, CheckID, CheckEmail, SignUp
          2순위 Logout
          3순위 ResetPasswort, UpdateUserInfo, WithDraw
         */

        public WebMessage<UserData> Login(string id, string password)
        {
            WebMessage<UserData> msg = new WebMessage<UserData>();
            UserData login = null;

            string sql = @"
select u.User_NO, u.User_ID, u.User_Name, u.Dept_ID, d.Dept_Name
from UserInfo u left outer join Department d on u.Dept_ID = d.Dept_ID
where u.User_ID = @ID and u.User_PWD = @Password and u.Delete = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    login = Helper.DataReaderMapToList<UserData>(reader)?.FirstOrDefault();

                    if (login != null)
                    {
                        msg.IsSuccess = true;
                        msg.ResultMessage = "로그인에 성공하였습니다.";
                        msg.Data = login;
                    }
                    else 
                    {
                        msg.IsSuccess = false;
                        msg.ResultMessage = "로그인 중 오류가 발생하였습니다.";
                        msg.Data = null;
                    }
                }
            }
            return msg;
        }

        public WebMessage Logout(UserData data)
        {
            // 세션, 쿠키등이 있으면 해제 작업을 함
            // 로그아웃은 DAC 부분에서는 작업할 내용이 없음 (API 부분에서 전부 처리)

            return new WebMessage() 
            {
                IsSuccess = true,
                ResultMessage = "로그아웃에 성공하였습니다."
            };
        }

        public WebMessage CheckID(string id)
        {
            WebMessage msg = new WebMessage();
            string sql = @"select User_ID from UserInfo where User_ID = @ID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                int iResult = cmd.ExecuteNonQuery();
                if (iResult > 0)
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "사용 중인 ID입니다.";
                }
                else
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "사용 가능한 ID입니다.";
                }
            }
            return msg;
        }

        public WebMessage CheckEmail(string email)
        {
            WebMessage msg = new WebMessage();
            string sql = @"select User_Email from UserInfo where User_Email = @Email and Deleted=0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                int iResult = cmd.ExecuteNonQuery();
                if (iResult > 0)
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "사용 중인 Email입니다.";
                }
                else
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "사용 가능한 Email입니다.";
                }
            }
            return msg;
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

        public WebMessage ResetPassword(string id, string email) 
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

        public WebMessage<UserData> UpdateUserInfo(string curId, string curPassword, UserInfo newInfo)
        {
            // 현재 아이디, 비밀번호 확인 -> 정보 수정

            WebMessage<UserData> msg = new WebMessage<UserData>();
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
                    msg.Data = new UserData()
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

        ///////////////////////////////////////////////////////////////////////////////////////
        public WebMessage<UserData> LoginTest(string id, string password)
        {
            return new WebMessage<UserData>()
            {
                IsSuccess = true,
                ResultMessage = "로그인에 성공하였습니다.",
                Data = new UserData()
                {
                    User_ID = "test",
                    User_NO = 1,
                    User_Name = "홍길동",
                    Dept_ID = 1,
                    Dept_Name = "영업부"
                }
            };
        }
        public WebMessage LogoutTest(UserData data)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "로그아웃에 성공하였습니다."
            };
        }
        public WebMessage CheckIDTest(string id)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "사용 가능한 ID입니다.."
            };
        }
        public WebMessage CheckEmailTest(string email)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "사용 가능한 Email입니다."
            };
        }
        public WebMessage SignUpTest(UserInfo info)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "회원가입에 성공하였습니다."
            };
        }

        //winform 회원가입
        public int Insert(UserInfo uer)
        {
            string sql = @"insert into UserInfo(User_ID, User_Name, User_PWD, User_phone, User_Birth, User_Email)
                                    values(@User_ID, @User_Name, @User_PWD, @User_phone, @User_Birth, @User_Email)";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@User_ID", uer.User_ID);
                cmd.Parameters.AddWithValue("@User_Name", uer.User_Name);
                cmd.Parameters.AddWithValue("@User_PWD", uer.User_PWD);
                cmd.Parameters.AddWithValue("@User_phone", uer.User_phone);
                cmd.Parameters.AddWithValue("@User_Birth", uer.User_Birth);
                cmd.Parameters.AddWithValue("@User_Email", uer.User_Email);


                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        //winform 로그인
        public UserInfo Login(string uID)
        {
            string sql = "select User_ID, User_PWD from UserInfo where User_ID=@User_ID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@User_ID", uID);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                UserInfo loginUser = new UserInfo();
                loginUser.User_ID = reader["User_ID"].ToString();
                loginUser.User_PWD = reader["User_PWD"].ToString();

                return loginUser;
            }
            else
            {
                return null;
            }
        }

        // 아이디가 있으면 True 아이디가 없으면 False
        public bool IDCheck(string id) 
        {
            string sql = "SELECT Count(*) FROM UserInfo WHERE User_ID=@User_ID;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@User_ID", id);
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            return (result > 0);
        }
    }
}
