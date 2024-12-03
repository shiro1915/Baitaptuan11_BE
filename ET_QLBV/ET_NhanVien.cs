using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public  class ET_NhanVien : ET_ConNguoi
    {
        private string chucVu;
        private DateTime ngayLV;

        public ET_NhanVien()
        {
           
        }

        public ET_NhanVien(string id, string ho, string ten, string dth, string diaChi, DateTime ngaySinh, string phai, string chucVu, DateTime ngayLV) : base(id, ho, ten, dth, diaChi, ngaySinh, phai)
        {
            this.chucVu = chucVu;
            this.ngayLV = ngayLV;
        }

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public DateTime NgayLV { get => ngayLV; set => ngayLV = value; }
    }
}
