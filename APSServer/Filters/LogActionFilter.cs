using APSLogger;
using APSServer.Util;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace APSServer.Filters
{
    public class APILoggerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            HttpRequestMessage request = actionExecutedContext.Request;
            
            ApplicationUserManager userManager = request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = request.GetRequestContext().Principal;
            
            string userID = userManager.FindById(user.Identity.GetUserId()).UserName;
            APILogger(userID, request);
        }

        public void APILogger(string userID, HttpRequestMessage reqMessage)
        {
            string method = reqMessage.Method.ToString();
            string path = reqMessage.RequestUri.AbsolutePath;

            string logStr = $"userID:{userID}\t{method}\t{path}";

            LoggingUtility logger = new LoggingUtility("apiLogger");
            logger.WriteInfo(logStr);
        }
    }
}