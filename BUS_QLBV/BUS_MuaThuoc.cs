using DAL_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBV;
using ET_QLBV;
namespace BUS_QLBV
{
    internal class BUS_MuaThuoc
    {
        DAL_MuaThuoc dal_muathuoc = new DAL_MuaThuoc();
        public DataTable getDataFromKhoa()
        {
            return dal_muathuoc.LoadData();
        }
        public bool ThemMuaThuoc(ET_MuaThuoc et_muathuoc)
        {
            return dal_muathuoc.ThemMuaThuoc(et_muathuoc);
        }
        public bool XoaMuaThuoc(ET_MuaThuoc et_muathuoc)
        {
            return dal_muathuoc.XoaMuaThuoc(et_muathuoc);
        }
        public bool SuaMuaThuoc(ET_MuaThuoc et_muathuoc)
        {
            return dal_muathuoc.SuaMuaThuoc(et_muathuoc);
        }
    }
}
