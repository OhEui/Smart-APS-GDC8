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
            Logger.APILogger(userID, request);
        }
    }
}