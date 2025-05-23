using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02_BT1_ThuVien
{
    internal class BanSaoSach
    {
        public string maSach;
        public int soBanSao;

        public BanSaoSach()
        {
            maSach = "";
            soBanSao = 0;
        }
        public BanSaoSach(string ms)
        {
            maSach = ms;
            soBanSao = 0;
        }

        public BanSaoSach(string maSach, int soBanSao)
        {
            this.maSach = maSach;
            this.soBanSao = soBanSao;
        }


        public void Xuat()
        {
            Console.WriteLine($"{maSach:20}  {soBanSao:10}");
        }
    }
}
