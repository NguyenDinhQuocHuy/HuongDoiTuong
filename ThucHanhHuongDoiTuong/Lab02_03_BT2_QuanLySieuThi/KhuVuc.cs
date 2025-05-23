using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_03_BT2_QuanLySieuThi
{
    class KhuVuc
    {
        public string ma;
        public string ten;
        public string chuyen;
        public KhuVuc()
        {
            ma = " ";
            ten = " ";
            chuyen = " ";
        }

        public KhuVuc(string ma, string ten, string chuyen )
        {
            this.ma = ma;
            this.ten = ten;
            this.chuyen = chuyen;
        }

        public KhuVuc(KhuVuc kv)
        {
            ma = kv.ma;
            ten = kv.ten;
            chuyen = kv.chuyen;
        }

        public void Xuat()
        {
            Console.WriteLine(ma.PadRight(15) + ten.PadRight(15) + chuyen.PadRight(15));
        }
    }
}
