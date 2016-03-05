using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSBook.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Isbn { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishedDate { get; set; }
        public int NumberOfPages { get; set; }
        public bool IsPublished {
            get { return PublishedDate < DateTime.Now; } 
           }

    }
}

