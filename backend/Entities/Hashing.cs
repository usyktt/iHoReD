using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Entities
{
    class Hashing
    {
        public static string GenerateSalt()
        {
            int workFactor = 12;
            return BCrypt.Net.BCrypt.GenerateSalt(workFactor);
        }

        public static string HashingPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GenerateSalt());
        }

        public static bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
