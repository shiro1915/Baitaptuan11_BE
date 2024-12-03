using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_PhongDieuTri
    {
        private string id;
        private string loaiPhong;

        public ET_PhongDieuTri()
        {
        }

        public ET_PhongDieuTri(string id, string loaiPhong)
        {
            this.id = id;
            this.loaiPhong = loaiPhong;
        }

        public string Id { get => id; set => id = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
    }
}
