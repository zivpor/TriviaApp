using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriviaApp.Models;
using TriviaApp.Services;


namespace TriviaApp.ViewModel
{
    public class UserAdminPageViewModel : ViewModel
    {
        TriviaAppService service;       
        private bool isRefreshing;

        public ObservableCollection<User> Users { get; set; }
        //טעינה
        public User SelectedUser { get; set; }
        public bool IsRefreshing { get => isRefreshing; set { isRefreshing = value; OnPropertyChanged(); } }
        public ICommand NavigateUserAdmim { get; private set; }
        public ICommand LoadUsersCommand { get; private set; }
        public ICommand RefreshCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public UserAdminPageViewModel()
        {
            Users = new ObservableCollection<User>();
            RefreshCommand = new Command(async () => await Refresh());
            LoadUsersCommand = new Command(async () => await LoadUsers());
            DeleteCommand = new Command((object obj) => Delete(obj));
        }

        //טעינת התלמידים
        private async Task LoadUsers()
        {
            TriviaAppService service = new TriviaAppService();
            //var fullList = await service.GetUsers();
            Users.Clear();
            //foreach (var user in fullList)
            //    Users.Add(user);

        }
        private async Task Refresh()
        {
            IsRefreshing = true;
            await LoadUsers();
            IsRefreshing = false;
        }
        private void Delete(object obj)
        {
            User s = obj as User;
            if (s != null)
                Users.Remove(s);		
        }




    }
}
