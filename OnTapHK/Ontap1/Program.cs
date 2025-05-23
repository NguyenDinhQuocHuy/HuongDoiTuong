using Ontap1;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        DanhSachNhanVien ds = new DanhSachNhanVien();
        
        while (true)
        {
            Console.Clear();
            XuatMenu();
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.Write("Nhap 1 string: ");
                    string s = Console.ReadLine();
                    if (s != null)
                        ds.NhapTuHang(s);
                    break;

                case 2:
                    ds.NhapTuFile();                    
                    Console.WriteLine("Da nhap xong !");
                    ds.Xuat();
                    break;

                case 3:
                    Console.Write("Nhap ten phong: ");
                    s = Console.ReadLine();
                    Console.WriteLine($"\n Danh sach quan ly theo phong {s}: ");
                    DanhSachNhanVien a = ds.TimQuanLyTheoPhong(s);
                    a.Xuat();
                    break;

                case 4:
                    Console.Write("Nhap ten phong: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Danh sach truoc khi xoa: ");
                    ds.Xuat();
                    Console.WriteLine("Sau khi xoa: ");
                    ds.XoaQuanLyTheoPhong(s);
                    ds.Xuat();
                    break;

                case 5:
                    Console.Write("Sap tang/giam (T/G): ");
                    var sx = Console.ReadLine();

                    if(sx == "T")
                    {
                        ds.SapXepTheoPhong(DanhSachNhanVien.SapXep.Tang);
                        ds.Xuat();
                    }

                    else
                    {
                        ds.SapXepTheoPhong(DanhSachNhanVien.SapXep.Giam);
                        ds.Xuat();
                    }
                        break;

                case 6:
                    Console.WriteLine("Nhap ma nhan vien: ");
                    s = Console.ReadLine();
                    ds.CapNhatThongTin(s);
                    break;

                default:
                    Console.WriteLine("Thoat chuong trinh");
                    return;
            }
            Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
            Console.ReadKey();
        }
    }

    static void XuatMenu()
    {
       
        Console.WriteLine("1. Nhap thu cong");
        Console.WriteLine("2. Doc va xuat tu file");
        Console.WriteLine("3. Tim quan ly thuoc phong nao do");
        Console.WriteLine("4. Xoa tat ca quan ly cua phong nao do");
        Console.WriteLine("5. Sap xep nhan vien theo chieu tang giam cua phong");
        Console.WriteLine("6. Cap nhat thong tin");
        Console.WriteLine("Nhap chon: ");
    }
}

