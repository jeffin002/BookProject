using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model1;
using BLL;

namespace Book_Project
{
    public partial class OrderView : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        OrderBll ob = new OrderBll();
        protected void Page_Load(object sender, EventArgs e)
        {           
            ba.AppUserId = Convert.ToInt32(Session["uid"]);
            string price = Math.Round(Convert.ToDecimal(ob.TotalPrice(ba)), 1).ToString();
            Label4.Text = price;
            
            if (Session["Daddr"] != null && Session["Daddr"] != DBNull.Value)
            {
                Label5.Text = Session["Daddr"].ToString();
            }
            else
            {
                string Address = ob.GetAddress(ba);
                Label5.Text = Address;                
            }            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeAddress.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ba.AppUserId = Convert.ToInt32(Session["uid"]);
            ba.TotalPrice = ob.TotalPrice(ba);
            if (Session["Daddr"] != null && Session["Daddr"] != DBNull.Value)
            {
                ba.Address = Session["Daddr"].ToString();
                
                
            }
            else
            {
                ba.Address = ob.GetAddress(ba);
            }
            
            int i = ob.AddOrder(ba);
            if(i > 0)
            {
                Session["oid"] = i;
                Response.Redirect("OrderSuccess.aspx");
            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "Error Occured";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Shoppingcart.aspx");
        }
    }
}