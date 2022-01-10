using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace APSEncrypt
{
    /// <summary>
    /// 단방향 암호화를 지원하는 SHA256 클래스입니다.
    /// </summary>
    public static class SHA256
    {
        public static (string hash, string salt) GenerateSaltedHash(string password)
        {
            var saltBytes = new byte[8];
            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetNonZeroBytes(saltBytes);
            }
            var salt = Convert.ToBase64String(saltBytes);

            //Rfc2898DeriveBytes 클래스는 PBKDF2(Password Based Key Derivation Function #2)로 알려진 방법을 사용하는
            //RFC2898 사양을 사용하여 해시를 생성하는 데 사용되며 현재 IETF(Internet Engineering Task Force)에서 권장
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            return (hash, salt);
        }
        
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == storedHash;
        }
    }

}
