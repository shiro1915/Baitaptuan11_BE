using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_HoaDon
    {
        private string id;
        private string dichVu;
        private string benhNhan;
        private string thuoc;
        private int sl;
        private double thanhTien;

        public ET_HoaDon()
        {
        }

        public ET_HoaDon(string id, string dichVu, string benhNhan, string thuoc, int sl, double thanhTien)
        {
            this.id = id;
            this.dichVu = dichVu;
            this.benhNhan = benhNhan;
            this.thuoc = thuoc;
            this.sl = sl;
            this.thanhTien = thanhTien;
        }

        public string Id { get => id; set => id = value; }
        public string DichVu { get => dichVu; set => dichVu = value; }
        public string BenhNhan { get => benhNhan; set => benhNhan = value; }
        public string Thuoc { get => thuoc; set => thuoc = value; }
        public int Sl { get => sl; set => sl = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
