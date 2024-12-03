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
    public class DAL_KhoaNV
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATKHOA_NV");
            conn.getClose();
            return dt;
        }
        public bool ThemKhoaNV(ET_KhoaNV khoanv)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMKHOA_NV", conn.Conn);
            cmd.CommandText = "SP_THEMKHOA_NV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoanv.Khoa));
            cmd.Parameters.Add(new SqlParameter("@MANV", khoanv.NhanVien));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool XoaKhoaNV(ET_KhoaNV khoanv)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOAKHOA_NV", conn.Conn);
            cmd.CommandText = "SP_XOAKHOA_NV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoanv.Khoa));
            cmd.Parameters.Add(new SqlParameter("@MANV", khoanv.NhanVien));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool SuaKhoaNV(ET_KhoaNV khoanv)
        {
            bool flat = false;
            SqlCommand cmd = new SqlCommand("SP_SUAKHOA_NV", conn.Conn);
            cmd.CommandText = "SP_SUAKHOA_NV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoanv.Khoa));
            cmd.Parameters.Add(new SqlParameter("@MANV", khoanv.NhanVien));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
    }
}
