using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HostelBase.HelpMethod
{
    class HashAndCheck
    {
        public static string HashPassword(string pass)
        {
            
            byte[] bytePass = Encoding.ASCII.GetBytes(pass);
            byte[] hashedPass = new SHA256Managed().ComputeHash(bytePass);
            return Encoding.ASCII.GetString(hashedPass);
        }

        public static bool CheckPassword(string pass, string hashedPass)
        {
            return HashPassword(pass) == hashedPass;
        }
    }
}
