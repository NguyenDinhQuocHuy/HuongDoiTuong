using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02_BT1_ThuVien
{
    internal class NXB
    {
        public string ten;
        public string diaChi;
        public string soDT;

        public NXB() 
        {

        }

        public NXB(string ten, string diaChi, string soDT)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.soDT = soDT;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten NXB: ");
            ten = Console.ReadLine();
            Console.Write("Nhap dia chi NXB: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap SDT: ");
            soDT = Console.ReadLine();
        }

       public void Xuat()
        {
            Console.WriteLine($"Ten NXB: {ten}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine($"SDT: {soDT}");
        } 
    }
}
