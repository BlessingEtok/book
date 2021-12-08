using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("AddUser")]
        public IActionResult AddUser()
        {
            return Ok();
        }

        [HttpGet("UserId")]
        public IActionResult GetUserId()
        {
            return Ok();
        }

        [HttpGet("GetAllUserByName")]
        public IActionResult GetUsersByName()
        {
            return Ok();
        }
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok();
        }

        [HttpPatch("UpdateUser")]

        public IActionResult UpdateUser()
        {
            return Ok();
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteUser()
        {
            return Ok();
        }
    }
}
