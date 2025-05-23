using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_03_BT2_QuanLySieuThi
{
    class MatHang
    {
        public string ma;
        public string ten;
        public string donViTinh;
        public double donGia;
        public List<string> nhaCungCap = new List<string>();

        public MatHang()
        {

        }

        public MatHang(string ma, string ten, string donViTinh, double donGia, List<string> nhaCungCap )
        {
            this.ma = ma;
            this.ten = ten;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.nhaCungCap = nhaCungCap;
        }

        public void Xuat()
        {
            Console.Write(ma.PadRight(20) + ten.PadRight(15) + donViTinh.PadRight(15) + donGia.ToString().PadRight(15));

            foreach (var i in nhaCungCap)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
