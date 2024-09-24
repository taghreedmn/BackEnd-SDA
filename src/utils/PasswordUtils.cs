using System.Security.Cryptography;
using System.Text;

namespace FusionTech.src.utils
{
    public static class PasswordUtils
    {
        public static void HashPassword(
            string originalPassword,
            out string hashedPassword,
            out byte[] salt
        )
        {
            var hmac = new HMACSHA256();
            salt = hmac.Key;
            hashedPassword = BitConverter.ToString(
                hmac.ComputeHash(Encoding.UTF8.GetBytes(originalPassword))
            );
        }

        public static bool isPasswordEqual(
            string originalPassword,
            string hashedPassword,
            byte[] salt
        )
        {
            var hmac = new HMACSHA256(salt);
            return BitConverter.ToString(hmac.ComputeHash(Encoding.UTF8.GetBytes(originalPassword)))
                == hashedPassword;
        }
    }
}
