using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_KhoaNV
    {
        private string khoa;
        private string nhanVien;

        public ET_KhoaNV()
        {
        }

        public ET_KhoaNV(string khoa, string nhanVien)
        {
            this.khoa = khoa;
            this.nhanVien = nhanVien;
        }

        public string Khoa { get => khoa; set => khoa = value; }
        public string NhanVien { get => nhanVien; set => nhanVien = value; }
    }
}
