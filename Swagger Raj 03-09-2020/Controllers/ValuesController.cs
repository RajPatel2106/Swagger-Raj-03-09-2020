using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authJwtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IEnumerable<Book> books = new Book[] { };

        // GET api/values
        [HttpGet, Authorize]
        public IEnumerable<Book> Get() 
        {
            var currentUser = HttpContext.User;
            var resultBookList = new Book[]
            {
                new Book{Author="Ray Bradbury",Title="Fahrenhit 451"},
                new Book{Author="Gabrial Gracia marquez",Title="100 years of Solitude"},
                new Book{Author="George Orwell",Title="1984"},
                new Book{Author="Anais Nin",Title="Delta of Venus"}

            };

            return resultBookList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(string value, string val)
        {
            //IList<Book> it = new Book[] { new Book { Author = "Ray Bradbury", Title = "Fahrenhit 451" } };
            //var st = new Book[] { };
            books.ToList().Add(new Book { Author = value, Title = val });
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public bool ageRestriction { get; set; }
    }
}
