using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_Thuoc
    {
        private string id;
        private string ten;
        private int sl;
        private double gia;

        public ET_Thuoc()
        {
        }

        public ET_Thuoc(string id, string ten, int sl, double gia)
        {
            this.id = id;
            this.ten = ten;
            this.sl = sl;
            this.gia = gia;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
