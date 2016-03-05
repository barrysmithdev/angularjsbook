﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSBook.Domain
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Bookses { get; set; }

    }
}
