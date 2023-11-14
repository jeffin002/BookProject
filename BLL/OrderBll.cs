using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model1;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    
    public class OrderBll
    {
        ConnectionCls con = new ConnectionCls();
        public string TotalPrice(BookAuthor ba)
        {
            string strprice = "select sum(ShoppingCart.Quantity*Book.BookUnitPrice)" +
                             " from ShoppingCart inner join Book on ShoppingCart.BookId = Book.BookId" +
                             " where ShoppingCart.AppUserID = " + ba.AppUserId + "";
            string price = con.Fn_Scalar(strprice);
            return price;
        }
        public string GetAddress(BookAuthor ba)
        {
            string stremail = "select Address from AppUser inner join Address on AppUser.Addressid=Address.AddressId where AppUserId=" + ba.AppUserId + "";
            string address = con.Fn_Scalar(stremail);
            return address;
        }
        public int AddOrder(BookAuthor ba)
        {
            string Addorder = "insert into bookorder values(Getdate()," + ba.TotalPrice + ",'" + ba.Address + "'," + ba.AppUserId + ");select Scope_identity()";
            int i = Convert.ToInt32(con.Fn_Scalar(Addorder));
            return i;
        }
        public DataSet orderdetails(BookAuthor ba)
        {
            string str = "Select orderid,ordertotal,orderaddress,orderdate from bookorder where orderid=" + ba.Orderid + "";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }
        public int changeaddress(BookAuthor ba)
        {
            string straddressid = "select addressid from appuser where appuserid=" + ba.AppUserId + "";
            int addressid = Convert.ToInt32(con.Fn_Scalar(straddressid));            
            string updateaddress = "update address set address='" + ba.NewAddress + "'where addressid=" + addressid + "";
            int i = con.Fn_NonQuery(updateaddress);
            return i;
        }
        public DataSet orders(BookAuthor ba)
        {
            string orders = "select orderid,orderdate,format(ordertotal,'n2') as ordertotal,orderaddress from bookorder where appuserid=" + ba.AppUserId + "";
            DataSet ds = con.Fn_DataSet(orders);
            return ds;
        }
        public int cheak(BookAuthor ba)
        {
            string cheak="Select AppRoleid from AppUserRole where Appuserid=" + ba.AppUserId + "";
            int i = Convert.ToInt32(con.Fn_Scalar(cheak));
            return i;
        }
    }
}
