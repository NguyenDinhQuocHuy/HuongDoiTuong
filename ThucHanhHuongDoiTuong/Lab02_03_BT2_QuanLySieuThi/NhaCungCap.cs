using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_03_BT2_QuanLySieuThi
{
    class NhaCungCap
    {
        public string ma;
        public string ten;
        public string maSoThue;
        public string diaChi;
        public List<string> soDT = new List<string>();
        public string email;
        public List<string> mh = new List<string>();

        public NhaCungCap()
        {

        }

        public NhaCungCap(string ma, string ten, string maSoThue, 
            string diaChi, string email, List<string> soDT,  List<string> mh)
        {
            this.ma = ma;
            this.ten = ten;
            this.maSoThue = maSoThue;
            this.diaChi = diaChi;
            this.email = email;
            this.soDT = soDT;           
            this.mh = mh;
        }

        public void Xuat()
        {
            Console.Write(ma.PadRight(20) + ten.PadRight(15) + maSoThue.PadRight(15) 
                + diaChi.PadRight(15) + email.PadRight(15));

            foreach (var i in soDT)
                Console.Write(i + " ");
            Console.Write("".PadRight(15));

            foreach(var i in mh)
                Console.Write(i + " ");
            Console.Write("".PadRight(15));
            Console.WriteLine();
        }
    }
}
