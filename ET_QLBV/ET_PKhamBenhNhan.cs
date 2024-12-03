using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_PKhamBenhNhan
    {
        private string phongKham;
        private string benhNhan;
        private DateTime NgayKham;

        public ET_PKhamBenhNhan()
        {
        }

        public ET_PKhamBenhNhan(string phongKham, string benhNhan, DateTime ngayKham)
        {
            this.phongKham = phongKham;
            this.benhNhan = benhNhan;
            NgayKham = ngayKham;
        }

        public string PhongKham { get => phongKham; set => phongKham = value; }
        public string BenhNhan { get => benhNhan; set => benhNhan = value; }
        public DateTime NgayKham1 { get => NgayKham; set => NgayKham = value; }
    }
}
