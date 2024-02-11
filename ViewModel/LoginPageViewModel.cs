using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using TriviaApp.Models;
using TriviaApp.Services;

namespace TriviaApp.ViewModel
{
    public class LoginPageViewModel:ViewModel 
    {
        private string username;
        private string password;
        private string theLogin;
        private Color theLoginColor;



        public string Username { get { return username; } set { username = value; OnPropertyChanged(); } }
        public string Password { get { return password; } set { password = value; OnPropertyChanged(); } }
        public string TheLogin { get { return theLogin; } set { theLogin = value; OnPropertyChanged(); } }
        public Color TheLoginColor { get { return theLoginColor; } set { theLoginColor = value; OnPropertyChanged(); } }
        public ICommand LoginCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        private User user;

        public LoginPageViewModel()
        {
            user = new User();
            LoginCommand = new Command(Login, () => !String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(Password));
            CancelCommand = new Command(Cancel, () => !String.IsNullOrEmpty(username) || !String.IsNullOrEmpty(Password));
        }

        public void Login()
        {
            TriviaAppService triviaApp = new TriviaAppService();
            bool isExist = triviaApp.Login( username, password);
            if (isExist == true)
            {
                theLogin = "התחבר בהצלחה";
                theLoginColor = Colors.DeepSkyBlue;
            }

            else
            {
                theLogin = "לא קיים משתמש";
                theLoginColor = Colors.DeepSkyBlue;
            }
        }

        public void Cancel()
        {
            TheLogin = string.Empty;
            username = string.Empty;
            Password = string.Empty;
            user = new User();
        }
    }
}
