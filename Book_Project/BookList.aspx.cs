using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;
using Model1;

namespace Book_Project
{
    public partial class BookList : System.Web.UI.Page
    {
       
        BookListBll bl = new BookListBll();
        BookAuthor ba = new BookAuthor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = bl.Category();
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
          

            
        }      
        

        protected void ImageButton2_Command(object sender, CommandEventArgs e)
        {
            ba.CategoryId = Convert.ToInt32(e.CommandArgument);
            Session["cid"] = ba.CategoryId;
            Response.Redirect("CategoryBookList.aspx");
        }
    }
}