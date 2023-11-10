using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class BookAuthor
    {
        public string BookName { get; set; }
        public string Address { get; set; }
        public string NewAddress { get; set; }


        public string Description { get; set; }
        public string CategoryDescription { get; set; }
        public decimal Price { get; set; }

        public string Image { get; set; }
        public string CategoryImage { get; set; }

        public string PublishedDate { get; set; }
        public string CategoryName { get; set; }

        public string AuthorName { get; set; }
        public string TotalPrice { get; set; }

        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public int AppUserId { get; set; }
        public int Quantity { get; set; }
        public int Orderid { get; set; }
        public int EditQuantity { get; set; }
        public int ShoppingCartId { get; set; }
    }
}
