using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_ConNguoi
    {
        private string id;
        private string ho;
        private string ten;
        private string dth;
        private string diaChi;
        private DateTime ngaySinh;
        private string phai;

        public ET_ConNguoi()
        {
        }

        public ET_ConNguoi(string id, string ho, string ten, string dth, string diaChi, DateTime ngaySinh, string phai)
        {
            this.id = id;
            this.ho = ho;
            this.ten = ten;
            this.dth = dth;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.phai = phai;
        }

        public string Id { get => id; set => id = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Dth { get => dth; set => dth = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Phai { get => phai; set => phai = value; }
    }
}
