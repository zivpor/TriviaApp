using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaApp.Models;

namespace TriviaApp.Services
{
    internal class TriviaAppService
    {
        List<User> users;

        public TriviaAppService() 
        {
            users = new List<User>();
            users.Add(new User() {UserName="NoaF" , Email="noa.fisher.2007@gmail.com", Password="110907n"});
            users.Add(new User() { UserName = "Shahar", Email = "shahar.oz298@gmail.com", Password = "290807s" });

        }

        public bool Login(string name, string pass, string email)
        {
            return users.Where(u=>u.UserName == name && u.Password == pass ).FirstOrDefault() != null;
        }

        

    }
}
