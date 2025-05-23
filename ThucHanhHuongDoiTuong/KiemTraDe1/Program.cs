using KiemTraDe1;
using System.Globalization;
internal class Program()
{
    static void Main()
    {
        DanhSachK ds = new DanhSachK();
        do
        {
            Console.Clear();
            XuatMenu();
            Console.Write("Nhap chon: ");
            int chon = int.Parse(Console.ReadLine());

            switch(chon)
            {
                case 1:
                    ds.DocTuFile();
                    Console.WriteLine("Da nhap xong!");
                    break;

                case 2:

                    break;

                case 3:
                    ds.HienThi();
                    break;

                case 4:
                    ds.DemDSTheoIA();
                    ds.DemDSTheoIB();
                    break;

                case 5:
                    DanhSachK kq1 = ds.TimCacKCoGiaTriYXuatHienItNhat();
                    DanhSachK kq2 = ds.TimCacKCoGiaTriYXuatHienNhieuNhat();
                    kq1.HienThi();
                    kq2.HienThi();
                    break;
            }

            if (chon >= 0)
                Console.ReadKey();
        } while (true);

    }

    static void XuatMenu()
    {
        Console.WriteLine("1. Nhap tu file");
        Console.WriteLine("2. Nhap thu cong");
        Console.WriteLine("3. Hien thi du lieu");
        Console.WriteLine("4. Dem danh sach K theo IA, IB");
        Console.WriteLine("5. Tim cac K co gia tri Y xuat hien nhieu nhat, it nhat");
        Console.WriteLine("6. Tim cac K theo IB co chieu dai cua C dai nhat, ngan nhat");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

    }
}
