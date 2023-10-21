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
    public partial class AddCategory : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        CategoryBll cb = new CategoryBll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/BookImage/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            ba.Image = p;
            int i = cb.categoryimage(ba);
            if(i == 1)
            {
                Label1.Text = "inserted";
            }
            else
            {
                Label1.Text = "Error";
            }
            

        }
    }
}