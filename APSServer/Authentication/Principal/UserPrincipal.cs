using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace APSServer.Principal
{
    public class UserPrincipal : UserData, IPrincipal
    {
        public IIdentity Identity { get; private set; }
        public bool IsInRole(string role) { return false; }

        public UserPrincipal(UserData data)
        {
            this.Identity = new GenericIdentity(data.User_ID);

            foreach (var info in typeof(UserData).GetProperties())
            {
                info.SetValue(this, info.GetValue(data));
            }
        }
    }
}