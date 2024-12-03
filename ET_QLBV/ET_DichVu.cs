using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_DichVu
    {
        private string id;
        private string ten;
        private double gia;

        public ET_DichVu()
        {
        }

        public ET_DichVu(string id, string ten, double gia)
        {
            this.id = id;
            this.ten = ten;
            this.gia = gia;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
