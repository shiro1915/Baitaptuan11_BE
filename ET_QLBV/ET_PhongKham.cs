using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_PhongKham
    {
        private string id;
        private string khoa;

        public ET_PhongKham()
        {
        }

        public ET_PhongKham(string id, string khoa)
        {
            this.id = id;
            this.khoa = khoa;
        }

        public string Id { get => id; set => id = value; }
        public string Khoa { get => khoa; set => khoa = value; }
    }
}
