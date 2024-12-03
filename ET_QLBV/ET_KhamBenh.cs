using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_KhamBenh
    {
        private string bacSi;
        private string benhNhan;
        private DateTime ngayKham;

        public ET_KhamBenh()
        {
        }

        public ET_KhamBenh(string bacSi, string benhNhan, DateTime ngayKham)
        {
            this.bacSi = bacSi;
            this.benhNhan = benhNhan;
            this.ngayKham = ngayKham;
        }

        public string BacSi { get => bacSi; set => bacSi = value; }
        public string BenhNhan { get => benhNhan; set => benhNhan = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
    }
}
