using APSServer.Principal;
using APSLogger;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Security.Principal;

namespace APSServer
{
    public static class Logger
    {
        public static void APILogger(IPrincipal principal, HttpRequestMessage reqMessage)
        {
            UserPrincipal user = principal as UserPrincipal;

            string userID = user?.User_ID ?? "anonymous";
            string method = reqMessage.Method.ToString();
            string path = reqMessage.RequestUri.AbsolutePath;

            string logStr = $"user:{userID} {path} {method}";
            
            LoggingUtility logger = new LoggingUtility("test");
            logger.WriteInfo(logStr);
        }
    }
}