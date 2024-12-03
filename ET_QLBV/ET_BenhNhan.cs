using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BenhNhan: ET_ConNguoi
    {
        private string phongDieuTri;

        public ET_BenhNhan()
        {
            
        }

        public ET_BenhNhan(string id, string ho, string ten, string dth, string diaChi, DateTime ngaySinh, string phai, string phongDieuTri) : base(id, ho, ten, dth, diaChi, ngaySinh, phai)
        {
            this.phongDieuTri = phongDieuTri;
        }

        public string PhongDieuTri { get => phongDieuTri; set => phongDieuTri = value; }
    }
}
