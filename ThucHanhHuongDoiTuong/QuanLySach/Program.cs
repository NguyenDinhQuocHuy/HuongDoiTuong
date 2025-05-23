using Lab02_02_BT1_ThuVien;

class Program
{
    static void Main()
    {
        ChiNhanh cn = new ChiNhanh();
        NXB nxb = new NXB();
        Sach sach = new Sach();
        BanSaoSach bs = new BanSaoSach();

        cn.Nhap();       
        sach.NhapTTSach(nxb);     

        Console.Clear();
        cn.Xuat();
        sach.XuatTTSach(nxb);
        

    }
}