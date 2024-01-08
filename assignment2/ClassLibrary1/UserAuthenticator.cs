using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        public bool RegisterUser(string username, string password)
        {
            if (!userDatabase.ContainsKey(username))
            {
                userDatabase.Add(username, password);
                return true;
            }
            return false;
        }

        public bool LoginUser(string username, string password)
        {
            if (userDatabase.TryGetValue(username, out var storedPassword))
            {
                return password == storedPassword;
            }
            return false;
        }

        public bool ChangePassword(string username, string newPassword)
        {
            if (userDatabase.ContainsKey(username))
            {
                userDatabase[username] = newPassword;
                return true;
            }
            return false;
        }
    }

}
