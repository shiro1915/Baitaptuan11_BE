using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBV
{
    public class ConnectDB
    {
        SqlConnection conn;

        public SqlConnection Conn { get => conn; }
        public void getConnect()
        {
            if (conn.State == ConnectionState.Open) return;
            conn = new SqlConnection("Data Source=SHIRO\\MSSQLSERVER01;Initial Catalog=QLBV;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
        }
        public void getClose()
        {
            if (conn.State == ConnectionState.Closed) return; 
            conn.Close();
        }

        public DataTable LoadData(string sql)
        {
            if(sql == null) return null;
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }
    }
}
