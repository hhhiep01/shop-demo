using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopdemo.Data.Services;
using shopdemo.Data.ViewModels;

namespace shopdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersService _usersService;
        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }
        [HttpPost("add-user")]
        public IActionResult AddItem([FromBody] UserVM user)
        {
            _usersService.AddUser(user);
            return Ok();
        }

        [HttpGet("get-all-user")]
        public IActionResult GetAllUser()
        {
           var allUser = _usersService.GetAllUser();
            return Ok(allUser);
        }

        [HttpGet("get-user-by-id")]
        public IActionResult GetUserByID(int id) 
        { 
            var user = _usersService.GetUserById(id);
            return Ok(user);
        }


    }
}
