using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BacSi
    {
        private string id;
        private string ho;
        private string ten;
        private string chucVu;
        private string khoa;

        public ET_BacSi()
        {
        }

        public ET_BacSi(string id, string ho, string ten, string chucVu, string khoa)
        {
            this.id = id;
            this.ho = ho;
            this.ten = ten;
            this.chucVu = chucVu;
            this.khoa = khoa;
        }

        public string Id { get => id; set => id = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Khoa { get => khoa; set => khoa = value; }
    }
}
