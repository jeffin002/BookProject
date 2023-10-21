using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model1;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    
    public class RegisterBll
    {
        ConnectionCls con = new ConnectionCls();
        AppUser Au = new AppUser();

        public DataSet RoleDropDown()
        {
            string str = "select RoleId,RoleName from Role";
            DataSet ds = con.Fn_DataSet(str);
            return ds;
        }
        public int Validation(string Username)
        {
            string qur = "select count(AppUserId) from appuser where username='" + Username + "'";
            int i = Convert.ToInt32(con.Fn_Scalar(qur));
            return i;
        }
        public int insertion(AppUser Au)
        {
            int k = 0;           
            string straddresstype = "insert into Address values('" + Au.Address + "','" + Au.District + "','" + Au.State + "','" + Au.Pincode + "'," + Au.AddressTypeshipping + ") SELECT SCOPE_IDENTITY()";
            int aid = Convert.ToInt32(con.Fn_Scalar(straddresstype));
            if(aid > 0)
            {
                
                string qurAppuser = "insert into Appuser values('" + Au.Name + "','" + Au.Phone + "','" + Au.Username + "','" + Au.Password + "',getdate(),getdate()," + aid + ")select SCOPE_IDENTITY()";
                int auid = Convert.ToInt32(con.Fn_Scalar(qurAppuser));
                if(auid > 0)
                {                    
                    //string strroleid = "select roleid from role where rolename='"+Au.Role+"'";
                    //int rid = Convert.ToInt32(con.Fn_Scalar(strroleid));
                    string strrole = "insert into AppUserRole values(" + auid + "," + Au.Role + ")";
                    k = con.Fn_NonQuery(strrole);
                }
                
            }
            return k;
        }
    }
}
