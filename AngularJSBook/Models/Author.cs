using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSBook.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string FullName {get { return FirstName+" "+LastName;}}
        public int[] Books { get; set; }
        public int NumberOfBooks {get { return Books.Count(); }
        }
    }
}


