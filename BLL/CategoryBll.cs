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

        public int  categoryimage(BookAuthor ba)
        {
            string s = "update category set image='"+ba.Image+"' where categoryid=1005 ";
            int i = con.Fn_NonQuery(s);
            return i;
        } 
    }
}
