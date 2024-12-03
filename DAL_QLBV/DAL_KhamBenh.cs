using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET_QLBV;
namespace DAL_QLBV
{
    public class DAL_KhamBenh
    {
       ConnectDB conn =new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATKHAM_BENH");
            conn.getClose();
            return dt;
        }
        public bool ThemKhamBenh(ET_KhamBenh khambenh)
        {
            bool flat= false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMKHAMBENH",conn.Conn);
            cmd.CommandText = "SP_THEMKHAMBENH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABS",khambenh.BacSi));
            cmd.Parameters.Add(new SqlParameter("@MABN", khambenh.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@NGAYKHAM", khambenh.NgayKham));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool XoaKhamBenh(ET_KhamBenh khambenh)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOAKHAMBENH",conn.Conn);
            cmd.CommandText = "SP_XOAKHAMBENH";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABS",khambenh.BacSi));
            cmd.Parameters.Add(new SqlParameter("@MABN",khambenh.BenhNhan));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool SuaKhamBenh(ET_KhamBenh khambenh)
        {
            bool flat= false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUAKHAMBENH",conn.Conn);
            cmd.CommandText = "SP_SUAKHAMBENH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABS", khambenh.BacSi));
            cmd.Parameters.Add(new SqlParameter("@MABN", khambenh.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@NGAYKHAM", khambenh.NgayKham));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }

    }
}
