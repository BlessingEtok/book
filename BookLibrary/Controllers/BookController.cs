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
    public class BookController : ControllerBase
    {
        [HttpPost("AddBook")]
        public IActionResult AddBook()
        {
            return Ok();
        }

        [HttpGet("BookName")]
        public IActionResult GetBookName()
        {
            return Ok();
        }

        


        [HttpGet("Id")]

        public IActionResult GetBookById()
        {
         return Ok();
        }
        [HttpPatch("UpdateBook")]

        public IActionResult UpdateBook()
        {
        return Ok();
        }
        //[HttpGet]
        //public IActionResult GetAllBooks()
        //{
        //    return Ok();
        //}

        [HttpGet("GetBookByAuthor")]
        public IActionResult GetBookByAuthor()
        {
        return Ok();
        }
        [HttpDelete("Delete")]

        public IActionResult DeleteBook()
        {
            return Ok();
        }
    }
}
