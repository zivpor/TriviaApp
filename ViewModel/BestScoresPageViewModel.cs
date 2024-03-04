
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using TriviaApp.Models;
using TriviaApp.Services;

namespace TriviaApp.ViewModel
{
    public class BestScoresPageViewModel : ViewModel
    {
        private bool isRefreshing; 
        public ObservableCollection<User> Users { get; set; }
        public ICommand LoadUsersCommand { get; private set; }
        public bool IsRefreshing { get => isRefreshing; set { isRefreshing = value; OnPropertyChanged(); } }


        public BestScoresPageViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadUsersCommand = new Command(async () => await
            LoadUsers());
        }

        private async Task LoadUsers()
        {
            if (IsRefreshing) return;
            IsRefreshing = true;
            Users.Clear();
            foreach (User u in Users)
            {
                TriviaAppService service = new TriviaAppService();
            }

        }

        private void GetUsers()
        {
            TriviaAppService service = new TriviaAppService();
            
        }
    }
}
