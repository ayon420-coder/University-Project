using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahad_Store.Necessities
{
    public static class Session
    {
        public static string UserId { get; private set; }
        public static string Username { get; private set; }
        public static bool IsLoggedIn => !string.IsNullOrEmpty(UserId);

        public static void Login(string userId, string username)
        {
            UserId = userId;
            Username = username;
        }

        public static void Logout()
        {
            UserId = null;
            Username = null;
        }
    }

}
