using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TriviaApp.ViewModel
{
    public class LoginPageViewModel:ViewModel 
    {
        private string username;
        private string password;

        public string Username { get { return username; } set { username = value; OnPropertyChanged(); } }
        public string Password { get { return password; } set { password = value; OnPropertyChanged(); } }

        public ICommand LoginCommand { get; set; }  

        public LoginPageViewModel()
        {

        }
    }
}
