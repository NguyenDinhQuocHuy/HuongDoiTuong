using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02_BT1_ThuVien
{
    internal class Sach
    {
        public string maSach;
        public string tenSach;
        public int soBanSao;
        NXB nhaXB = new NXB();
        public string tacGia;

        public Sach()
        {

        }

        public Sach(string maSach, string tenSach, NXB nhaXB, string tacGia)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.nhaXB = nhaXB;
            this.tacGia = tacGia;
        }

        public void NhapTTSach(NXB nhaXB)
        {
            Console.Write("Nhap ma sach: ");
            maSach = Console.ReadLine();
            Console.Write("Nhap so ban sao: ");
            soBanSao = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.WriteLine("Nhap thong tin nha xuat ban: ");
            nhaXB.Nhap();          
        }

        public void XuatTTSach(NXB nhaXB)
        {
            Console.WriteLine($"Ma sach: {maSach}");
            Console.WriteLine($"So ban sao: {soBanSao}");
            Console.WriteLine($"Ten sach: {tenSach}");
            nhaXB.Xuat();
        }
    }
}
