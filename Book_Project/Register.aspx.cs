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
    public partial class Register : System.Web.UI.Page
    {
        AppUser Au = new AppUser();
        RegisterBll uv = new RegisterBll();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            { 
             if(!IsPostBack)
             {
                    DataSet ds = uv.RoleDropDown();
                    DropDownList1.DataSource = ds;
                    DropDownList1.DataTextField = "RoleName";
                    DropDownList1.DataValueField = "RoleId";
                    DropDownList1.DataBind();
             }            
                      
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Au.Username = TextBox7.Text;
            int i = uv.Validation(Au.Username);
            if(i == 0)
            {
                if (TextBox8.Text == TextBox9.Text)
                {
                    Au.Role = Convert.ToInt32(DropDownList1.SelectedValue);
                    Au.Name = TextBox1.Text;
                    Au.Phone = TextBox2.Text;
                    Au.Address = TextBox3.Text;
                    Au.State = TextBox4.Text;
                    Au.District = TextBox5.Text;
                    Au.Pincode = TextBox6.Text;
                    Au.Password = TextBox8.Text;

                    int k = uv.insertion(Au);

                    if(k > 0)
                    {
                        lblinsert.Visible = true;
                        lblinsert.Text = "inserted";
                    }

                }
                else
                {
                    lblmissmatch.Visible = true;
                    lblmissmatch.Text = "incorrect password";
                }
            }
            else
            {
                lblusernamevalidation.Visible = true;
                lblusernamevalidation.Text = "Username alredy exist";
            }



        }
    }
}