using BookLibrary.Services;
using Microsoft.AspNetCore.Authorization;
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
    public class AuthorizationController : ControllerBase
    {

    
        private readonly IService _jwt; public AuthorizationController(IService jwt)
        {
            _jwt = jwt;
        }
        [HttpPost("Signin")]
        public IActionResult Signin()
        {
            return Ok(_jwt.GenerateToken());
        }

        [HttpPost("Register")]

        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPost("ForgotPassword")]

        public IActionResult ForgotPassword()
        {
            return Ok();
        }

        [HttpPost("LogOut")]

        public IActionResult LogOut()
        {
            return Ok();
        }

       // [HttpGet]
       // [Authorize]
      //  public IActionResult Authorize()
       // {
         //   return Ok("Authorized");
       // }


    }
}
