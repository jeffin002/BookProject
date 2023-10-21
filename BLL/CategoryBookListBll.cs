using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CategoryBookListBll
    {
        ConnectionCls con = new ConnectionCls();
        BookAuthor ba = new BookAuthor();

        public DataSet BookList(BookAuthor ba)
        {
            string str = "select BookName,BookDescription,BookUnitPrice,BookImage,PublishedDate,AuthorName" +
                         " from Book " +
                         "join BookAuthor on Book.BookId=BookAuthor.BookId " +
                         "join Author on BookAuthor.AuthorId=Author.AuthorId where CategoryId="+ba.CategoryId+"";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }

    }
}
