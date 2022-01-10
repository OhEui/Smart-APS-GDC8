using System;

namespace APSUtil.Http
{
    /// <summary>
    /// 인증에 필요한 access_token을 관리합니다.
    /// </summary>
    public sealed class TokenStorage
    {
        private static readonly Lazy<TokenStorage> _instance = 
            new Lazy<TokenStorage>(()=>new TokenStorage(),isThreadSafe: true);
        private string _accessToken = "";

        private TokenStorage() { }

        /// <summary>
        /// 현재 저장되어 있는access_token 입니다.
        /// </summary>
        public static string AccessToken
        {
            get => _instance.Value._accessToken;

            set => _instance.Value._accessToken = value;
        }

        /// <summary>
        /// access_token이 저장되어 있으면 true, 그렇지 않을 경우 false를 반환합니다.
        /// </summary>
        public static bool IsTokenStoraged => _instance.IsValueCreated && !string.IsNullOrWhiteSpace(_instance.Value._accessToken);
        
        /// <summary>
        /// 현재 저장되어있는 access_token을 삭제합니다.
        /// </summary>
        public static void Clear()
        {
            if (_instance.IsValueCreated)
            {
                _instance.Value._accessToken = "";
            }
        }
    }
}
