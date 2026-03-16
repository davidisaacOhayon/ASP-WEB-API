using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Refresher.Controllers 
{
    [Microsoft.AspNetCore.Mvc.Route("api/Customer")]
    [ApiController]
    public class UserController : ControllerBase
    {


        [HttpGet("/getCustomerName/{Id}")]
        public IActionResult GetCustomerName(string Id)
        {
            return Ok($"Okay bro {Id}");
        }



        
    }
}
