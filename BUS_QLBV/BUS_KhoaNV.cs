using DAL_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLBV;
using DAL_QLBV;
namespace BUS_QLBV
{
    internal class BUS_KhoaNV
    {
        DAL_Khoa dal_khoa = new DAL_Khoa();
        public DataTable getDataFromKhoa()
        {
            return dal_khoa.LoadData();
        }
        public bool ThemKhoaNV(ET_Khoa et_Khoanv)
        {
            return dal_khoa.(et_Khoanv);
        }
        public bool XoaKhoaNV(ET_Khoa et_Khoanv)
        {
            return dal_khoa.XoaKHoa(et_Khoanv);
        }
        public bool SuaKhoaNV(ET_Khoa et_Khoanv)
        {
            return dal_khoa.SuaKhoa(et_Khoanv);
        }
    }
}
