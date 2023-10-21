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
    public partial class Login : System.Web.UI.Page
    {
        AppUser au = new AppUser();
        LoginBll lb = new LoginBll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            au.Username = txtusername.Text;
            au.Password = txtpassword.Text;
            int k = lb.cid(au);
            if(k > 0)
            {
                int i = lb.Login(au);
                if (i > 0)
                {
                    int j = lb.LoginRole(i);
                    if (j == 1)
                    {
                        Response.Redirect("AdminView.aspx");
                    }
                    else if (j == 2)
                    {
                        Response.Redirect("UserView.aspx");
                    }

                }
            }
            
            else
            {
                Label1.Visible = true;
                Label1.Text = "Incorrect username and password";
            }
        }
    }
}