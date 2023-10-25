﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class BookAuthor
    {
        public string BookName { get; set; }

        public string Description { get; set; }
        public string CategoryDescription { get; set; }
        public decimal Price { get; set; }

        public string Image { get; set; }
        public string CategoryImage { get; set; }

        public string PublishedDate { get; set; }
        public string CategoryName { get; set; }

        public string AuthorName { get; set; }

        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}
