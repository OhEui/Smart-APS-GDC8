using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public interface IUserInfo
    {
        string Email { get; set; }
        string ID { get; set; }
        string Name { get; set; }
        int EmpNo { get; set; }
        string Phone { get; set; }
        DateTime Birthday { get; set; }

    }

    public class UserInfo : IUserInfo
    {
        public string Email { get; set; }
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public int EmpNo { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString() => $"ID:{ID}\nName:{Name}\nPhone:{Phone}\nBirthday:{Birthday:yyyy-MM-dd}";
        
    }

}
