using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Model1;

namespace Book_Project
{
    public partial class Shoppingcart : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        ShoppingCartBll scb = new ShoppingCartBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_bind();
                Label2.Text = TotalQuantity(ba).ToString();
                Label4.Text = TotalPrice(ba);
            }            
            
        }
        public void grid_bind()
        {
            ba.AppUserId = Convert.ToInt16(Session["uid"]);
            DataSet ds = scb.shoppingcart(ba);
            GridView1.DataSource = ds;
            GridView1.DataBind();            
        }
        public int TotalQuantity(BookAuthor ba)
        {
            ba.AppUserId = Convert.ToInt16(Session["uid"]);
            int i = scb.Totalquantity(ba);            
            return i;
        }
        public string TotalPrice(BookAuthor ba)
        {
            ba.AppUserId = Convert.ToInt16(Session["uid"]);            
            string j = Math.Round(Convert.ToDecimal(scb.TotalPrice(ba)),1).ToString();
            return j;
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            ba.ShoppingCartId = Convert.ToInt32(e.CommandArgument);
            int i = scb.deletequantity(ba);
            if (i > 0)
            {
                grid_bind();
                Label2.Text = TotalQuantity(ba).ToString();
                Label4.Text = TotalPrice(ba);
            }

        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Session["scid"]=e.CommandArgument;
            Response.Redirect("ShoppingCartEdit.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            Response.Redirect("OrderView.aspx");
        }
    }
}