using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Refresher.Models.dbContext;
using Refresher.Models;
using Refresher.Service;

namespace Refresher.Controllers 
{
    [Microsoft.AspNetCore.Mvc.Route("api/Customer")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private readonly RefDbContext _dbContext;
        private UserService _userService;
 


        public UserController(RefDbContext dbContext, UserService userService) { 
            _dbContext = dbContext;
            _userService = userService;
        }



        [HttpGet("/getUser/{id}")]
        public IActionResult GetUser(string id) {


            // Check if user exists 
            if (_userService.UserExists(id))
            {
                User user = _userService.GetUser(id);

                return Ok(new { Username = user.UserName }); 
            }
            
            


            
        
        }
        [HttpGet("/getCustomerName/{Id}")]
        public IActionResult GetCustomerName(string Id)
        {
            
        }



        
    }
}
