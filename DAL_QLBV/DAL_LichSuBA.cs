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
    public class DAL_LichSuBA
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATLICHSU_BA");
            conn.getClose();
            return dt;
        }
        public bool ThemLichSuBenhAn(ET_LichSuBA lichsu)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMLICHSU_BA", conn.Conn);
            cmd.CommandText = "SP_THEMLICHSU_BA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABS", lichsu.BacSi));
            cmd.Parameters.Add(new SqlParameter("@MABA", lichsu.BenhAn));
            cmd.Parameters.Add(new SqlParameter("@NGAYVIET", lichsu.NgayViet));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool XoaLichSuBenhAn(ET_LichSuBA lichsu)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOALICHSU_BA", conn.Conn);
            cmd.CommandText = "SP_XOALICHSU_BA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABS", lichsu.BacSi));
            cmd.Parameters.Add(new SqlParameter("@MABA", lichsu.BenhAn));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool SuaLichSuBenhAn(ET_LichSuBA lichsu)
        {
            bool flat = false;
            SqlCommand cmd = new SqlCommand("SP_SUALICHSU_BA", conn.Conn);
            cmd.CommandText = "SP_SUALICHSU_BA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABS", lichsu.BacSi));
            cmd.Parameters.Add(new SqlParameter("@MABA", lichsu.BenhAn));
            cmd.Parameters.Add(new SqlParameter("@NGAYVIET", lichsu.NgayViet));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
    }
}
