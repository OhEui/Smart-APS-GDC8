using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSWinForm
{
    /// <summary>
    /// 로그인한 유저의 정보를 로그아웃 전까지 저장합니다.
    /// </summary>
    public sealed class UserInfoStorage : IUserInfo
    {
        public static event EventHandler UserInfoUpdated;

        private static readonly Lazy<UserInfoStorage> _instance =
            new Lazy<UserInfoStorage>(() => new UserInfoStorage(), isThreadSafe: true);

        private UserInfo _info = null;

        private UserInfoStorage() { }


        /// <summary>
        /// 로그인 유저정보가 저장되어 있으면 true, 그렇지 않을 경우 false를 반환합니다.
        /// </summary>
        /// 
        public static bool IsStoraged => _instance.IsValueCreated && _instance.Value._info != null;

        /// <summary>
        /// 저장되어 있는 로그인 유저정보입니다.
        /// </summary>
        public static UserInfo Current
        {
            get => _instance.Value._info;
            set
            {
                _instance.Value._info = value;
                UserInfoUpdated?.Invoke(null, new EventArgs());
            }
        }

        public int EmpNo { get => _info.EmpNo; set => _info.EmpNo = value; }
        public string ID { get => _info.ID; set => _info.ID = value; }
        public string Email { get => _info.Email; set => _info.Email = value; }
        public string Name { get => _info.Name; set => _info.Name = value; }
        public string Phone { get => _info.Phone; set => _info.Phone = value; }
        public DateTime Birthday { get => _info.Birthday; set => _info.Birthday = value; }

        public int Auth_ID { get => _info.Auth_ID; set => _info.Auth_ID = value; }



        /// <summary>
        /// 현재 저장되어있는 로그인 유저정보를 삭제합니다.
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
