using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBV;
using ET_QLBV;
namespace BUS_QLBV
{
    internal class BUS_HoaDon
    {
        DAL_HoaDon dal_hoadon= new DAL_HoaDon();
        public DataTable getDataFromHoaDon()
        {
            return dal_hoadon.LoadData();
        }
        public bool ThemHoaDon(ET_HoaDon et_HoaDon)
        {
            return dal_hoadon.ThemHD(et_HoaDon);
        }
        public bool XoaKhoa(ET_HoaDon et_HoaDon)
        {
            return dal_hoadon.XoaHoaDon(et_HoaDon);
        }

        public bool SuaKhoa(ET_HoaDon et_HoaDon)
        {
            return dal_hoadon.SuaHoaDon(et_HoaDon);
        }
    }
    
}
