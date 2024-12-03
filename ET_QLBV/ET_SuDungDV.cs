using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_SuDungDV
    {
        private string dichVu;
        private string benhNhan;
        private DateTime ngay;
        private int sl;

        public ET_SuDungDV()
        {
        }

        public ET_SuDungDV(string dichVu, string benhNhan, DateTime ngay, int sl)
        {
            this.dichVu = dichVu;
            this.benhNhan = benhNhan;
            this.ngay = ngay;
            this.sl = sl;
        }

        public string DichVu { get => dichVu; set => dichVu = value; }
        public string BenhNhan { get => benhNhan; set => benhNhan = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
