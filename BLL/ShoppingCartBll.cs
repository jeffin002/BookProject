using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using Model1;

namespace BLL
{
    public class ShoppingCartBll
    {
        BookAuthor ba = new BookAuthor();
        ConnectionCls con = new ConnectionCls();
        public DataSet shoppingcart(BookAuthor ba)
        {
            string str = "select shoppingcartid,BookName,BookDescription,Bookimage,Authorname,Bookunitprice,Quantity,updateddate " +
               "from shoppingcart inner join Book on shoppingcart.BookId = Book.BookId " +
               "inner join BookAuthor on Book.BookId = BookAuthor.BookId " +
               "inner join Author on BookAuthor.AuthorId = Author.AuthorId " +
               "where AppUserID = " + ba.AppUserId + "";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }
        public int deletequantity(BookAuthor ba)
        {
            string str = "select quantity from shoppingcart where shoppingcartid=" + ba.ShoppingCartId + "";
            int i = Convert.ToInt32(con.Fn_Scalar(str));
            ba.Quantity = i - 1;
            if (ba.Quantity > 0)
            {
                string update = "update shoppingcart set quantity=" + ba.Quantity + " where shoppingcartid=" + ba.ShoppingCartId + "";
                int j = con.Fn_NonQuery(update);
                return j;
            }
            else
            {
                string delete = "delete from shoppingcart where shoppingcartid=" + ba.ShoppingCartId + "";
                int k = con.Fn_NonQuery(delete);
                return k;
            }
        }
        public int Totalquantity(BookAuthor ba)
        {
            string strquantity = "select sum(quantity) from shoppingcart where Appuserid=" + ba.AppUserId + "";
            int quantity = Convert.ToInt32(con.Fn_Scalar(strquantity));
            return quantity;
        }
        public string TotalPrice(BookAuthor ba)
        {
            string strprice = "select sum(ShoppingCart.Quantity*Book.BookUnitPrice)" +
                             " from ShoppingCart inner join Book on ShoppingCart.BookId = Book.BookId" +
                             " where ShoppingCart.AppUserID = " + ba.AppUserId + "";
            string price = con.Fn_Scalar(strprice);
            return price;
        }

        public SqlDataReader EditShoppingCart(BookAuthor ba)
        {
            string edit = "select BookName,Bookunitprice,Quantity from ShoppingCart" +
                         " inner join Book on ShoppingCart.BookId = Book.BookId where ShoppingCartId = " + ba.ShoppingCartId + "";
            SqlDataReader dr = con.Fn_Reader(edit);
            return dr;
        }

        public int Quantity(BookAuthor ba)
        {
            string strquantity = "select quantity from shoppingcart where shoppingcartid=" + ba.ShoppingCartId + "";
            int quantity = Convert.ToInt32(con.Fn_Scalar(strquantity));
            return quantity;
        }

        public int UpdateEditQuantity(BookAuthor ba)
        {
            string update = "update shoppingcart set quantity=" + ba.EditQuantity + " where shoppingcartid=" + ba.ShoppingCartId + "";
            int j = con.Fn_NonQuery(update);
            return j;
        }
    }
}
