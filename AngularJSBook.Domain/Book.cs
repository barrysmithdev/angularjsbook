using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSBook.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string PublisherName { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public string Language { get; set; }
        public int PublicationYear { get; set; }
        public string Isbn13 { get; set; }
        public string Isbn10 { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }

    }
}
