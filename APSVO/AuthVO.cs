using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class UserVO
    {
        public string User_Name { get; set; }
        public string User_ID { get; set; }
        public string auth_id { get; set; }
        public string User_PWD { get; set; }

        public string auth_name { get; set; }
    }

    public class AuthVO
    {
        public int Auth_ID { get; set; }
        public string Auth_Name { get; set; }
        public string auth_Desc { get; set; }

    }
}
