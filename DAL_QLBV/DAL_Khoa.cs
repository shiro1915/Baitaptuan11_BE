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
    public class DAL_Khoa
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATKHOA");
            conn.getClose();
            return dt;
        }
        public bool ThemKhoa(ET_Khoa khoa)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMKHOA", conn.Conn);
            cmd.CommandText = "SP_THEMKHOA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoa.Id));
            cmd.Parameters.Add(new SqlParameter("@TENK", khoa.Name));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool XoaKHoa(ET_Khoa khoa)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOAKHOA", conn.Conn);
            cmd.CommandText = "SP_XOAKHOA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK",khoa.Id ));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
        public bool SuaKhoa(ET_Khoa khoa)
        {
            bool flat = false;
            SqlCommand cmd = new SqlCommand("SP_SUAKHOA", conn.Conn);
            cmd.CommandText = "SP_SUAKHOA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoa.Id));
            cmd.Parameters.Add(new SqlParameter("@TENK", khoa.Name));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getConnect();
            return flat;
        }
    }
}
