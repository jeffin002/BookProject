using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;
using Model1;
using System.Globalization;

namespace Book_Project
{
    public partial class AddBook : System.Web.UI.Page
    {
        BookAuthor ba = new BookAuthor();
        AddBookBll ab = new BLL.AddBookBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = ab.category();
                DropDownList1.DataSource = ds;
                DropDownList1.DataValueField = "Categoryid";
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("Select a category"));
            }

        }

        protected void btnupload_Click(object sender, EventArgs e)        
        {

            int i = 0;           
                if (FileUpload1.FileName != "")
                {
                    string p = "~/BookImage/" + FileUpload1.FileName;
                    FileUpload1.SaveAs(MapPath(p));
                    ba.Image = p;
                    Session["UploadedFilePath"] = p;
                    i = i + 1;
                    Label9.Visible = false;
                }
                else
                {
                    Label9.Visible = true;
                    Label9.Text = "Upload the image";
                }
            
            

            if (DropDownList1.SelectedIndex > 0)
            {
                ba.CategoryId = Convert.ToInt32(DropDownList1.SelectedValue);
                i = i + 1;
                lblcategory.Visible = false;

            }
            else
            {
                lblcategory.Visible = true;
                lblcategory.Text = "select a category";
            }
            if (txtbookname.Text != "")
            {
                ba.BookName = txtbookname.Text;
                i = i + 1;
                Label6.Visible = false;

            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "Enter the book name";

            }
            if (txtdescription.Text != "")
            {
                ba.Description = txtdescription.Text;
                i = i + 1;
                Label7.Visible = false;

            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "Enter the description";
            }
            if (TextBox1.Text != "")
            {
                ba.Price = Convert.ToInt32(TextBox1.Text);
                i = i + 1;
                Label8.Visible = false;

            }
            else
            {
                Label8.Visible = true;
                Label8.Text = "Enter the price";
            }           

            if (Calendar1.SelectedDate != DateTime.MinValue)
            {
                ba.PublishedDate = Calendar1.SelectedDate.ToShortDateString();               
                //ba.PublishedDate = publisheddate;
                i = i + 1;
                Label10.Visible = false;

            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "select a date";
            }
            if (txtauthor.Text != "")
            {
                ba.AuthorName = txtauthor.Text;
                i = i + 1;
                Label11.Visible = false;

            }
            else
            {
                Label11.Visible = true;
                Label11.Text = "Enter the author name";
            }
            if (i == 7)
            {
                int l = ab.insert(ba);
                if(l == 3)
                {
                    Response.Redirect("AdminView.aspx");
                }

            }
            else
            {
                Label12.Visible = true;
                Label12.Text = "Some fields are missing";
            }
        }
    }
}