using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ET_QLBV;

namespace DAL_QLBV
{
    
    public class DAL_BacSi
    {
        ConnectDB conn  = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq =  conn.LoadData("SP_XUATBACSI");
                conn.getClose();
                return kq;
                
            }
            catch (Exception ex)
            {
                throw ex; 
            }
           
        }
        public bool ThemBacSi(ET_BacSi bs)
        {
            bool flag = false;
            SqlCommand cmd = new SqlCommand("",conn.Conn);
            cmd.CommandText = "";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("", bs.Id));
            cmd.Parameters.Add(new SqlParameter("", bs.Ho));
            cmd.Parameters.Add(new SqlParameter("", bs.Ten));
            cmd.Parameters.Add(new SqlParameter("", bs.ChucVu));
            cmd.Parameters.Add(new SqlParameter("", bs.Khoa));
            if(cmd.ExecuteNonQuery()>0) flag = true;
            return flag;
        }
        public bool XoaBacSi(ET_BacSi bs)
        {
            bool flag = false;
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("", bs.Id));          
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            return flag;
        }
        public bool SuaBacSi(ET_BacSi bs)
        {
            bool flag = false;
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("", bs.Id));
            cmd.Parameters.Add(new SqlParameter("", bs.Ho));
            cmd.Parameters.Add(new SqlParameter("", bs.Ten));
            cmd.Parameters.Add(new SqlParameter("", bs.ChucVu));
            cmd.Parameters.Add(new SqlParameter("", bs.Khoa));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            return flag;
        }
    }
}
