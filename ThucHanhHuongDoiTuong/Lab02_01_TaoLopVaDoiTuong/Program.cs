using Lab02_01_TaoLopVaDoiTuong;

class Program
{
    static void Main()
    {
        
        PhanSo ps = new PhanSo();
        ps.Nhap();
        ps.Xuat();

        PhanSo a = new PhanSo(1, 2);
        a.Xuat();

        PhanSo b = new PhanSo(3, 4);
        b.Xuat();

        PhanSo c = a.Cong(b);
        c.Xuat();

        PhanSo d = a.Tru(b);
        d.Xuat();

        PhanSo e = a.Nhan(b);
        e.Xuat();

        PhanSo f = a.Chia(b);
        f.Xuat();

        PhanSo g = new PhanSo(2, 4);
        g.Xuat();
        g.RutGon();
        g.Xuat();
    }
}
