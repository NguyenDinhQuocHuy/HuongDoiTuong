using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02_BT1_ThuVien
{
    internal class ChiNhanh
    {
        public string maCN;
        public string tenCN;
        public string diaChi;

        public ChiNhanh()
        {
            maCN = "";
            tenCN = "";
            diaChi = "";
        }

        public ChiNhanh(string maCN, string tenCN, string diaChi)
        {
            this.maCN = maCN;
            this.tenCN = tenCN;
            this.diaChi = diaChi;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma chi nhanh: ");
            maCN = Console.ReadLine();
            Console.Write("Nhap ten chi nhanh: ");
            tenCN = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();           
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma chi nhanh: {maCN}");
            Console.WriteLine($"Ten chi nhanh: {tenCN}");
            Console.WriteLine($"Dia chi: {diaChi}");
        }
    }
}
