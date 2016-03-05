using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSBook.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}
