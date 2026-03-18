
using Refresher.Entities;
using Refresher.Models;
using Refresher.Models.ViewModels;
using System;
using System.Collections.Generic;
namespace Refresher.Service.Repository
{
    public interface IUserRepository  
    {
        IEnumerable<User> GetUsers();
        bool UserExists(string id);
        User GetUser(string id);

        Response RegisterUser(CreateAccountViewModel user);

        void DeleteUser(User user);

        IEnumerable<Device> GetUserDevices(string id);
    }
}
