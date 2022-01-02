using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class UserData
    {
        public int User_NO { get; set; }
        public string User_ID { get; set; }
        public string User_Name { get; set; }
        public int Dept_ID { get; set; }
        public string Dept_Name { get; set; }
    }

    public class UserVerify : UserData
    {
        public string User_PWD { get; set; }
        public string Salt { get; set; }
    }
}
