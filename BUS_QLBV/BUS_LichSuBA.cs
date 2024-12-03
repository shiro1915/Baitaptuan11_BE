using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLBV;
using DAL_QLBV;
using System.Data;
namespace BUS_QLBV
{
    internal class BUS_LichSuBA
    {
        DAL_LichSuBA dal_lichsu = new DAL_LichSuBA();
        public DataTable getDataFromKhoa()
        {
            return dal_lichsu.LoadData();
        }
        public bool ThemLichSu(ET_LichSuBA et_lichsu)
        {
            return dal_lichsu.ThemLichSuBenhAn(et_lichsu);
        }
        public bool XoaLichSu(ET_LichSuBA et_lichsu)
        {
            return dal_lichsu.XoaLichSuBenhAn(et_lichsu);
        }
        public bool SuaLichSu(ET_LichSuBA et_lichsu)
        {
            return dal_lichsu.SuaLichSuBenhAn(et_lichsu);
        }
    }
}
