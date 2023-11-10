using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model1;

namespace Book_Project
{
    public partial class ChangeAddress : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        OrderBll ob = new OrderBll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "")
            {
                Session["Daddr"] = TextBox1.Text;
                Response.Redirect("OrderView.aspx");
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "Enter Address";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ba.AppUserId = Convert.ToInt32(Session["uid"]);            
            ba.NewAddress = TextBox1.Text;
            int i = ob.changeaddress(ba);
            if(i > 0)
            {
                Response.Redirect("OrderView.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderView.aspx");
        }
    }
}