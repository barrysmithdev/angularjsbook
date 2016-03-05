using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSBook.Models;

namespace AngularJSBook.Controllers
{
    public class AuthorsController : ApiController
    {
        private IList<Author> _authors = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    FirstName = "Emily",
                    LastName = "Bronte",
                    Books = new int[]{1},
                },
                new Author()
                {
                         Id = 2,
                    FirstName = "John",
                    LastName = "Skeet",
                    Books = new int[]{5,6},
                },
                 new Author()
                {
                   Id = 3,
                    FirstName = "Irvine",
                    LastName = "Welsh",
                     Books = new int[]{2,3,4},
                },

            };
        // GET: api/Book
        public IHttpActionResult Get()
        {
            if (_authors.Count == 0)
                return NotFound();
            return Ok(_authors);

        }

        // GET: api/Book/5
        public IHttpActionResult Get(int id)
        {
            var book = _authors.Single(x => x.Id == id);
            if (book == null)
            {
                return NotFound(); // Returns a NotFoundResult
            }
            return Ok(book);
        }

        // POST: api/Book
        public IHttpActionResult Post([FromBody]Author author)
        {
            _authors.Add(author);
            if (author != null)
            {
                return Created<Author>(Request.RequestUri + author.Id.ToString(), author);
            }
            else
            {
                return Conflict();
            }
        }

        // PUT: api/Author/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Author/5
        public void Delete(int id)
        {
        }
    }
}
