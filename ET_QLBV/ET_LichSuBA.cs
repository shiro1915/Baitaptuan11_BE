using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_LichSuBA
    {
        private string bacSi;
        private string benhAn;
        private DateTime ngayViet;

        public ET_LichSuBA()
        {
        }

        public ET_LichSuBA(string bacSi, string benhAn, DateTime ngayViet)
        {
            this.bacSi = bacSi;
            this.benhAn = benhAn;
            this.ngayViet = ngayViet;
        }

        public string BacSi { get => bacSi; set => bacSi = value; }
        public string BenhAn { get => benhAn; set => benhAn = value; }
        public DateTime NgayViet { get => ngayViet; set => ngayViet = value; }
    }
}
