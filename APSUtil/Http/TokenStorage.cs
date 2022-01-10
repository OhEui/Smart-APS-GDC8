using System;

namespace APSUtil.Http
{
    public sealed class TokenStorage
    {
        private static readonly Lazy<TokenStorage> _instance = 
            new Lazy<TokenStorage>(()=>new TokenStorage(),isThreadSafe: true);
        private string _accessToken = "";

        private TokenStorage() { }

        public static string AccessToken
        {
            get => _instance.Value._accessToken;
            set => _instance.Value._accessToken = value;
        }

        public static bool IsTokenStoraged => _instance.IsValueCreated && !string.IsNullOrWhiteSpace(_instance.Value._accessToken);
        
        public static void Clear()
        {
            if (_instance.IsValueCreated)
            {
                _instance.Value._accessToken = "";
            }
        }
    }
}
