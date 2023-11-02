using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CategoryBookListBll
    {
        ConnectionCls con = new ConnectionCls();
        BookAuthor ba = new BookAuthor();

        public DataSet BookList(BookAuthor ba)
        {
            string str = "select Book.Bookid,BookName,BookDescription,BookUnitPrice,BookImage,PublishedDate,AuthorName" +
                         " from Book " +
                         "join BookAuthor on Book.BookId=BookAuthor.BookId " +
                         "join Author on BookAuthor.AuthorId=Author.AuthorId where CategoryId="+ba.CategoryId+"";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }
        public int AddToCart(BookAuthor ba)
        {
            string str = "select count(shoppingcartid) from shoppingcart where bookid='" + ba.BookId + "' and AppUserid='" + ba.AppUserId + "'";
            int i = Convert.ToInt32(con.Fn_Scalar(str));
            if(i > 0)
            {
                string scid = "select shoppingcartid from shoppingcart where bookid='" + ba.BookId + "' and AppUserid='" + ba.AppUserId + "'";
                int j = Convert.ToInt32(con.Fn_Scalar(scid));
                string quantity = "select quantity from shoppingcart where shoppingcartid=" + j + "";
                int existingquantity = Convert.ToInt32(con.Fn_Scalar(quantity));
                ba.Quantity = existingquantity + 1;
                string updatestr = "update ShoppingCart set updateddate=getdate(),quantity=" + ba.Quantity + " where shoppingcartid="+j+"";
                int k = con.Fn_NonQuery(updatestr);
                return k;
            }
            else
            {
                string addcart = "insert into shoppingcart values(" + ba.BookId + "," + ba.AppUserId + ",getdate(),getdate()," + 1 + ")";
                int l = con.Fn_NonQuery(addcart);
                return l;
            }
        }
    }
}
