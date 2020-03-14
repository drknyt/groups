using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;

        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpGet("/{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok(UserService.GetUser(id));
        }
    }
}