using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSWinForm
{
    public sealed class UserInfoStorage
    {
        private static readonly Lazy<UserInfoStorage> _instance =
            new Lazy<UserInfoStorage>(() => new UserInfoStorage(), isThreadSafe: true);

        private UserInfo _info = null;

        private UserInfoStorage() { }


        /// <summary>
        /// 로그인 유저 정보가 저장되어 있으면 true, 그렇지 않을 경우 false를 반환합니다.
        /// </summary>
        public static bool IsStoraged => _instance.IsValueCreated && _instance.Value._info != null;

        /// <summary>
        /// 현재 저장되어있는 로그인 유저 정보를 삭제합니다.
        /// </summary>
        public static void Clear()
        {
            if (_instance.IsValueCreated)
            {
                _instance.Value._info = null;
            }
        }
    }
}
