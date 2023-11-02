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
            int j = 0;
            if(txtname.Text != "")
            {
                ba.CategoryName = txtname.Text;
                lblnamevalidation.Visible = false;
                j = j + 1;
            }
            else
            {
                lblnamevalidation.Visible = true;
                lblnamevalidation.Text = "Enter name";

            }
            if (txtdescription.Text != "")
            {
                ba.CategoryDescription = txtdescription.Text;
                lbldescriptionvalidation.Visible = false;
                j = j + 1;

            }
            else
            {
                lbldescriptionvalidation.Visible = true;
                lbldescriptionvalidation.Text = "Enter description";

            }
            
            if(FileUpload1.FileName != "")
            {
                string p = "~/BookImage/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(p));
                ba.CategoryImage = p;
                lblimagevalidation.Visible = false;
                j = j + 1;

            }
            else
            {
                lblimagevalidation.Visible = true;
                lblimagevalidation.Text = "Insert image";

            }
            if(j == 3)
            {
                int i = cb.categorydetails(ba);
                if (i == 1)
                {
                    lblinsert.Visible = true;
                    lblinsert.Text = "inserted";
                }
            }   
            else
            {
                lblinsert.Visible = true;
                lblinsert.Text = "Fill All Details";                
            }
            

        }
    }
}