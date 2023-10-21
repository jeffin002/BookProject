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
    public class BookListBll
    {
        ConnectionCls con = new ConnectionCls();
        
        public DataSet Category()
        {
            string str = "select categoryid,image from Category";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }
    }
}
