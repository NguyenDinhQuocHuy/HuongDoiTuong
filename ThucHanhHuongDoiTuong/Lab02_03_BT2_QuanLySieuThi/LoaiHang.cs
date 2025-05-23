using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_03_BT2_QuanLySieuThi
{
    class LoaiHang
    {
        public string ma;
        public string ten;
        public List <string> mh;
        

        public LoaiHang()
        {

        }

        public LoaiHang(string ma, string ten, List<string> mh)
        {
            this.ma = ma;
            this.ten = ten;
            this.mh = mh;
        }

        public void Xuat()
        {
            Console.Write(ma.PadRight(20) + ten.PadRight(15));    
            
                foreach (var i in mh)
                    Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    
}
