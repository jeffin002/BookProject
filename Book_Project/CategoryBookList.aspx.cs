using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model1;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace Book_Project
{
    public partial class CategoryBookList : System.Web.UI.Page
    {
        

        BookAuthor ba = new BookAuthor();
        CategoryBookListBll cbl = new CategoryBookListBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ba.CategoryId = Convert.ToInt32(Session["cid"]);
                DataSet ds = cbl.BookList(ba);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }            
        }

       

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            ba.AppUserId = Convert.ToInt32(Session["uid"]);
            ba.BookId = Convert.ToInt32(e.CommandArgument);
            int i = cbl.AddToCart(ba);
            if(i > 0)
            {
                Response.Redirect("Shoppingcart.aspx");
            }
            
            
        }


    }
}