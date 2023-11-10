using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model1;
using System.Data;
using System.Data.SqlClient ;

namespace Book_Project
{
    public partial class Orders : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        OrderBll ob = new OrderBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            ba.AppUserId = Convert.ToInt32(Session["uid"]);
            DataSet ds=ob.orders(ba);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}