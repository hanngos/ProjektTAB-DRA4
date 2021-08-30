using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;

namespace projekt_TAB
{
    public class OtherUtils
    {
        public static Dictionary<string, Color> statusColor = new Dictionary<string, Color> {
            {"OPN", Color.Blue},
            {"FIN", Color.Green},
            {"ASS", Color.DarkOrange},
            {"PRO", Color.Purple},
            {"CAN", Color.Red}
        };
        public static string HashPassword(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);
            return Encoding.Default.GetString(sha1data);
        }
    }
}
