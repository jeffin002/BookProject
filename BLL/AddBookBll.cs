using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using Model1;

namespace BLL
{
     public class AddBookBll
     {
        BookAuthor ba = new BookAuthor();
        ConnectionCls con = new ConnectionCls();

        public DataSet category()
        {
            string str = "select Categoryid,name from category";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }
        public int insert(BookAuthor ba)
        {
            int l = 0;
            string bookinsert = "insert into book values('" + ba.BookName + "','" + ba.Description + "'," + ba.Price + "," + 1 + ",'" + ba.Image + "'," + ba.CategoryId + ",'" + ba.PublishedDate + "') select scope_identity()";
            int i = Convert.ToInt32(con.Fn_Scalar(bookinsert));
            l = l + 1;
            if(i > 0)
            {
                string authorinsert = "insert into author values('" + ba.AuthorName + "')select scope_identity()";
                int j = Convert.ToInt32(con.Fn_Scalar(authorinsert));
                l = l + 1;
                if (j > 0)
                {
                    string insertbookauthor = "insert into bookauthor values(" + i + "," + j + ")";
                    int k = con.Fn_NonQuery(insertbookauthor);
                    l = l + 1;
                }
            }
            return l;
        }
       
     }
}
