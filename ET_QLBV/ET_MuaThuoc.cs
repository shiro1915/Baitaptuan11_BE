using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_MuaThuoc
    {
        private string thuoc;
        private string benhNhan;
        private int sl;

        public ET_MuaThuoc()
        {
        }

        public ET_MuaThuoc(string thuoc, string benhNhan, int sl)
        {
            this.thuoc = thuoc;
            this.benhNhan = benhNhan;
            this.sl = sl;
        }

        public string Thuoc { get => thuoc; set => thuoc = value; }
        public string BenhNhan { get => benhNhan; set => benhNhan = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
