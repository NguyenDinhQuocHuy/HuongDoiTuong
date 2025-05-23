using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_01_TaoLopVaDoiTuong
{
    
    internal class PhanSo
    {
        public int tu;
        public int mau;
        public PhanSo()
        {
            mau = 1;  
        }
        public PhanSo(int t, int m)
        {
            this.tu = t;
            this.mau = m;
        }
        public PhanSo(PhanSo p)
        {
            tu = p.tu;
            mau = p.mau;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            mau = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"{tu}/{mau}");
        }

        public override string ToString()
        {
            return tu + "/" + mau;
        }

        // Cong 2 phan so
        public PhanSo Cong(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = this.tu * a.mau + this.mau * a.tu;
            kq.mau = this.mau * a.mau;
            return kq;
        }

        // Tru 2 phan so
        public PhanSo Tru(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = this.tu * a.mau - this.mau * a.tu;
            kq.mau = this.mau * a.mau;
            return kq;
        }

        // Nhan 2 phan so
        public PhanSo Nhan(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * this.tu;
            kq.mau = a.mau * this.mau;
            return kq;
        }

        // Chia 2 phan so
        public PhanSo Chia(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = this.tu * a.mau;
            kq.mau = this.mau * a.tu;
            return kq;
        }

        // Rut gon phan so
        public static int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int tam = b;
                b = a % b;
                a = tam;
            }
            return a;
        }

        public PhanSo RutGon()
        {
            int ucln = TimUCLN(this.tu, this.mau);
            this.tu /= ucln;
            this.mau /= ucln;
            return this;
        }
        
    }
}
