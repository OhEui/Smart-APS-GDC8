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

        public WebMessage<UserLogin> Login(string id, string password) 
        {
            return new WebMessage<UserLogin>()
            {
                IsSuccess = true,
                ResultMessage = "로그인에 성공하였습니다.",
                Data = new UserLogin() 
                {
                    User_ID = "test",
                    User_NO = 1,
                    User_Name = "홍길동",
                    Dept_ID = 1,
                    Dept_Name = "영업부"
                }
            };
        }

        public WebMessage Logout(UserLogin data)
        {
            return new WebMessage() 
            {
                IsSuccess = true,
                ResultMessage = "로그아웃에 성공하였습니다."
            };
        }

        public WebMessage CheckID(string id)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "사용가능한 ID입니다."
            };
        }

        public WebMessage CheckEmail(string email)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "사용가능한 Email입니다."
            };
        }

        public WebMessage SignUp(UserInfo info)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "회원가입에 성공하였습니다."
            };
        }

        public WebMessage ResetPasswort(string id, string email) 
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "임시비밀번호를 계정과 연결된 이메일로 전송하였습니다."
            };
        }

        public WebMessage UpdateUserInfo(UserInfo info)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "회원정보를 수정하였습니다."
            };
        }

        public WebMessage WithDraw(UserLogin data)
        {
            return new WebMessage()
            {
                IsSuccess = true,
                ResultMessage = "회원탈퇴를 하였습니다."
            };
        }
    }
}
