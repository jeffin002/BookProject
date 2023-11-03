using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model1;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace Book_Project
{
    public partial class ShoppingCartEdit : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        ShoppingCartBll scb = new ShoppingCartBll();

        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ba.ShoppingCartId = Convert.ToInt32(Session["scid"]);
            SqlDataReader dr = scb.EditShoppingCart(ba);
            while (dr.Read())
            {
                Label2.Text = dr["BookName"].ToString();
                Label9.Text = dr["BookUnitprice"].ToString();
                Label4.Text = dr["Quantity"].ToString();
            }
            if (RadioButtonList1.SelectedValue != "")
            {
                ba.Quantity = scb.Quantity(ba);
                if (RadioButtonList1.SelectedValue == "1")
                {
                    ba.EditQuantity = ba.Quantity + Convert.ToInt32(DropDownList1.SelectedValue);
                    Label6.Visible = true;

                    Label7.Visible = true;
                    Label7.Text = ba.EditQuantity.ToString();
                    i = 1;
                }
                if (RadioButtonList1.SelectedValue == "0")
                {
                    if (ba.Quantity >= Convert.ToInt32(DropDownList1.SelectedValue))
                    {
                        ba.EditQuantity = ba.Quantity - Convert.ToInt32(DropDownList1.SelectedValue);
                        Label7.Visible = true;
                        Label6.Visible = true;

                        Label7.Text = ba.EditQuantity.ToString();
                        i = 1;
                    }
                    else
                    {
                        Label6.Visible = false;
                        Label7.Visible = true;
                        Label7.Text = "Exixting quantity is less";
                        i = 0;
                    }

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ba.ShoppingCartId = Convert.ToInt32(Session["scid"]);
            if(i == 1)
            {
                if (RadioButtonList1.SelectedValue == "1")
                {
                    ba.EditQuantity = ba.Quantity + Convert.ToInt32(DropDownList1.SelectedValue);
                }
                else
                {
                    ba.EditQuantity = ba.Quantity - Convert.ToInt32(DropDownList1.SelectedValue);
                }
                int j = scb.UpdateEditQuantity(ba);
                if(j == 1)
                {
                    Response.Redirect("ShoppingCart.aspx");
                }
            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "Field Requited";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}