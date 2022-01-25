﻿using APSLogger;
using System.Net.Http;

namespace APSServer.Util
{
    public static class Logger
    {
        public static void APILogger(string userID, HttpRequestMessage reqMessage)
        {
            string method = reqMessage.Method.ToString();
            string path = reqMessage.RequestUri.AbsolutePath;

            string logStr = $"userID:{userID}\t{method}\t{path}";

            LoggingUtility logger = new LoggingUtility("apiLogger");
            logger.WriteInfo(logStr);
        }
    }
}