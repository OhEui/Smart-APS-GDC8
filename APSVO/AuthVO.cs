using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class UserVO
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Auth_ID { get; set; }
        public int Empno { get; set; }

        public string auth_name { get; set; }
    }

    public class UserVOs
    {
     
        public string Id { get; set; }
        public int Auth_ID { get; set; }
        public int Empno { get; set; }

    }

    public class AuthVO
    {
        public int Auth_ID { get; set; }
        public string Auth_Name { get; set; }
        public string auth_Desc { get; set; }

    }

    public class UserInfoVO
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
    }

}
