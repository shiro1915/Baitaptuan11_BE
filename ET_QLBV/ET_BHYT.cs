using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BHYT
    {
        private string id;
        private string benhNhan;
        private DateTime ngayCap;
        private DateTime ngayHetHan;

        public ET_BHYT()
        {
        }

        public ET_BHYT(string id, string benhNhan, DateTime ngayCap, DateTime ngayHetHan)
        {
            this.id = id;
            this.benhNhan = benhNhan;
            this.ngayCap = ngayCap;
            this.ngayHetHan = ngayHetHan;
        }

        public string Id { get => id; set => id = value; }
        public string BenhNhan { get => benhNhan; set => benhNhan = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
    }
}
