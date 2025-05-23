using Lab08_QuanLyPhuongTien_DaKeThua;
internal class Program()
{
    static void Main()
    {
        DanhSachPhuongTien ds = new DanhSachPhuongTien();
        while (true)
        {
            Console.Clear();
            XuatMenu();
            Console.Write("Nhap chon: ");
            int chon = int.Parse(Console.ReadLine());

            switch(chon)
            {
                case 1:
                    ds.ReadFromFile("data.txt");
                    Console.WriteLine("Da nhap xong !");
                    break;

                case 2:
                    Console.WriteLine("Nhap vao mot dong theo cau truc sau: ");
                    Console.WriteLine("Loai,Ten,TocDo,SoChoNgoi(Neu la car)");
                    string line = Console.ReadLine();
                    if (line != null)
                        ds.AddVehicleFromLine(line);
                    break;

                case 3:
                    Console.WriteLine("Danh sach Vehicle: ");
                    ds.Show();
                    break;

                case 4:
                    Console.WriteLine("Tang toc, giam toc cua Motorcycle");
                    Vehicle m = new Motorcycle("AB", 120);
                    ((Motorcycle)m).TangToc();
                    ((Motorcycle)m).GiamToc();
                    break;

                case 5:
                    Console.WriteLine("Goi phuong thuc DongCua cua ICar");
                    Vehicle c = new Car("Nissan", 200, 2);
                    ((Car)c).DongCua();
                    break;

                case 6:

                    break;

                default:
                    Console.WriteLine("Thoat chuong trinh !");
                    return;
            }
            Console.WriteLine("Nhan 1 phim bat ky de tiep tuc !");
            Console.ReadKey();

        }
    }

    static void XuatMenu()
    {
        Console.WriteLine("Chon chuc nang (Luon nhap 1 truoc): ");
    }
}

