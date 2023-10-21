using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model1;

namespace BLL
{
    
    public class LoginBll
    {
        ConnectionCls con = new ConnectionCls();
        public int cid(AppUser au)
        {
            string strcid = "select count(Appuserid) from appuser where username='" + au.Username + "'and password='" + au.Password + "'";
            int k = Convert.ToInt32(con.Fn_Scalar(strcid));
            return k;
        }
        public int Login(AppUser au)
        {
            
            string str = "select Appuserid from appuser where username='" + au.Username + "'and password='" + au.Password + "'";
            int i = Convert.ToInt32(con.Fn_Scalar(str));
            return i;
        }
        public int LoginRole(int i)
        {
            string str = "select AppRoleId from AppUserRole where AppUserId=" + i + "";
            int j = Convert.ToInt32(con.Fn_Scalar(str));
            return j;
        }
    }
}
