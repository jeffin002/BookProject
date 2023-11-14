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
            bool isDataSetEmpty = ds.Tables.Cast<DataTable>().All(table => table.Rows.Count == 0);
            if (isDataSetEmpty)
            {
                Label1.Visible = true;
                Label1.Text = "No Previous Orders!";
            }
            else
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }           
        }
    }
}