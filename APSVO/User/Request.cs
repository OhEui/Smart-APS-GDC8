using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class ReqUserLogin
    {
        public string ID { get; set; }
        public string Password { get; set; }
    }

    public class ReqUserResetPassword 
    {
        public string id { get; set; }
        public string email { get; set; }
    }

    public class ReqUserUpdateInfo
    {
        public string Cur_ID { get; set; }
        public string Cur_PWD { get; set; }

        public UserInfo NewInfo { get; set; }
    }
}
