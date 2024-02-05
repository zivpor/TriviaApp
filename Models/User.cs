using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaApp.Models
{
    public class User
    {
        private string userName;
        private string email;
        private string password;

        public string UserName { get { return userName; } set { userName = value; } }

        public string Email { get { return email; } set { email = value; } }

        public string Password { get { return password; } set { password = value; } }


    }
}
