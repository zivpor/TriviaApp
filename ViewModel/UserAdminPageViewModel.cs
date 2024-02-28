using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaApp.Models;
using TriviaApp.Services;
using Xamarin.Google.Crypto.Tink.Mac;
using static Java.Util.Jar.Attributes;

namespace TriviaApp.ViewModel
{
    public class UserAdminPageViewModel:ViewModel
    {
        private User player;
        public User Player { get { return player; } set { player = value; GetPlayer(); } }
        private string username;
        public string Username  { get { return username; } set { this.username = value; OnPropertyChanged();}}


        private void GetPlayer()
        {
            if (Player != null)
            {
                username = Player.UserName;
                Location = Monkey.Location;
                ImageUrl = Monkey.ImageUrl;
            }
        }
    }
}
