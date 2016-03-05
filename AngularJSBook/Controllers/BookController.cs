using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSBook.Models;
using AngularJSBook.Repositories;

namespace AngularJSBook.Controllers
{
    public class BooksController : ApiController
    {

        private BookStoreContext db = new BookStoreContext();


        public BooksController()
        {
            
        }
        // GET: api/Book
        public IHttpActionResult Get()
        {
            if (_books.Count == 0)
                return NotFound();
            return Ok(_books);
         
        }

        // GET: api/Book/5
        public IHttpActionResult Get(int id)
        {
            var book = _books.Single(x => x.Id == id);
            if (book == null)
            {
                return NotFound(); // Returns a NotFoundResult
            }
            return Ok(book); 
        }

        // POST: api/Book
        public IHttpActionResult Post([FromBody]Book book)
        {
             _books.Add(book);
             if (book != null)
            {
                return Created<Book>(Request.RequestUri + book.Id.ToString(), book);
            }
            else
            {
                return Conflict();
            }
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }

        private readonly IList<Book> _books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Wuthering Heights",
                    Description = "Wuthering Heights description",
                    Isbn = "1853260010",
                    PublishedDate = new DateTime(1992, 5, 12),
                    NumberOfPages = 882,
                    AuthorId = 1,
                },
                new Book()
                {
                     Id = 2,
                    Title = "Glue",
                    Description = "Glue description",
                    Isbn = "1853243243",
                    PublishedDate = new DateTime(2012,11, 25),
                    NumberOfPages = 882,
                    AuthorId =  3,
                },
                   new Book()
                {
                     Id = 3,
                    Title = "Trainspotting",
                    Description = "Trainspotting description",
                    Isbn = "9725260010",
                    PublishedDate = new DateTime(2001, 9, 3),
                    NumberOfPages = 882,
                    AuthorId = 3,
                },
                new Book()
                {
                     Id = 4,
                    Title = "Filth",
                    Description = "Filth description",
                    Isbn = "2253265618",
                    PublishedDate = new DateTime(1998,7, 7),
                    NumberOfPages = 882,
                    AuthorId =  3,
                },
                new Book()
                {
                     Id = 5,
                    Title = "C# In Depth CLR 3",
                    Description = "C# In Depth CLR 3 description",
                    Isbn = "7653234618",
                    PublishedDate = new DateTime(2011, 6, 10),
                    NumberOfPages = 882,
                    AuthorId = 2,
                },
                  new Book()
                {
                     Id = 6,
                    Title = "C# In Depth CLR 3",
                    Description = "C# In Depth CLR 3 description",
                    Isbn = "7653234618",
                    PublishedDate = new DateTime(2016, 2, 10),
                    NumberOfPages = 882,
                    AuthorId =2,
                },

            };
      
    }
}

