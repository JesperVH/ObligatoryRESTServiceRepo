using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookLib.Models;

namespace ObligatoryRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static readonly List<Book> books = new List<Book>()
        {
            new Book("Codex Astartes", "Roboute Guilliman", 5917, "9412572156601"),
            new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987")
        };

        // GET: api/Books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public Book Get(string iSBN)
        {
            return books.Find(b =>b.ISBN == iSBN);
        }

        // POST: api/Books
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            books.Add(value);
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public void Put(string iSBN, [FromBody] Book value)
        {
            Book book = Get(iSBN);
            if (book != null)
            {
                book.Title = value.Title;
                book.Author = value.Author;
                book.PageNR = value.PageNR;
                book.ISBN = value.ISBN;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string iSBN)
        {
            Book book = Get(iSBN);
            books.Remove(book);
        }
    }
}
