using System.Security.Cryptography;
using System.Text;

namespace UsuariosApp.Application.Helpers
{
    public class Sha1Helper
    {
        public static string Encrypt(string value)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                var hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(value));
                var sb = new StringBuilder();

                foreach (var item in hashBytes)
                    sb.Append(item.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}