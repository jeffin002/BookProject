using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model1;

namespace BLL
{
    
    
    public class CategoryBll
    {
        ConnectionCls con = new ConnectionCls();
        BookAuthor ba = new BookAuthor();

        public int  categorydetails(BookAuthor ba)
        {
            string s = "insert into category values('"+ba.CategoryName+"','"+ba.CategoryDescription+"','"+ba.CategoryImage+"')";
            int i = con.Fn_NonQuery(s);
            return i;
        } 
    }
}
