using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model1;
using System.Data;
using System.Data.SqlClient;

namespace Book_Project
{
    public partial class OrderSuccess : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        OrderBll ob = new OrderBll();
        protected void Page_Load(object sender, EventArgs e)
        {            
             ba.Orderid=Convert.ToInt32(Session["oid"]);
            DataSet ds = ob.orderdetails(ba);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminView.aspx");
        }
    }
}