using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_DieuTri
    {
        private string maKhoa;
        private string maBenhNhan;

        public ET_DieuTri()
        {
        }

        public ET_DieuTri(string maKhoa, string maBenhNhan)
        {
            this.maKhoa = maKhoa;
            this.maBenhNhan = maBenhNhan;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
    }
}
