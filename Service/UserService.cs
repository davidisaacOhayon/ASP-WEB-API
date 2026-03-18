using Refresher.Models.dbContext;
using Refresher.Service.Repository;
using Refresher.Models;
using Refresher.Entities;
using Microsoft.AspNetCore.Identity;
using Refresher.Models.ViewModels;
using System.ComponentModel;
namespace Refresher.Service
{
    public class UserService : IUserRepository
    {

        private readonly RefDbContext _dbContext;

        private readonly UserManager<User> _userManager;
        public UserService(RefDbContext refDbContext, UserManager<User> userManager)
        {
            // Assign the Database Context
            _dbContext = refDbContext;

            // Assign user manager
            _userManager = userManager;

        }


        public bool UserExists(string id)
        {
            return _dbContext.Users.Where(x => x.Id == id).First() != null;
        }


        public User GetUser(string id)
        {
            // Assumes you already run a validation check if user exists.
            User user = null;
 
            user = _dbContext.Users.Where(x => x.Id == id).First(); 

            return user;        

        }


        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }


        // Check if appropriate
        public Response RegisterUser(CreateAccountViewModel user)
        {
 
            string password = user.Password;
            string username = user.Username;
            string email = user.Email;

            User newUser = new User
            {
                UserName = username,
                Email = email
            };

            // Create user asynchronously, handles hashing of password
            var result = _userManager.CreateAsync(newUser, password);

            if (result.IsCompletedSuccessfully) {
                return new Response(true);
             }else
            {
                return new Response("An error has occured in creating user", false);
            }
        }

        public void DeleteUser(User user)
        {
            _dbContext.Users.Remove(user);

            _dbContext.SaveChanges();
        }
        
    }
}
