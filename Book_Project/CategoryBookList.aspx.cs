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
            ba.CategoryId = Convert.ToInt32(Session["cid"]);
            DataSet ds = cbl.BookList(ba);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}