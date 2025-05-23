
using Lab02_03_BT2_QuanLySieuThi;
internal class Program
{
    static void Main()
    {
        List<KhuVuc> dskv = new List<KhuVuc>()
        {
            new KhuVuc("1", "Khu vuc 1", "Ca"),
            new KhuVuc("2", "Khu vuc 2", "Thit"),
            new KhuVuc("3", "Khu vuc 3", "Tom"),
            new KhuVuc("4", "Khu vuc 4", "Trung"),
            new KhuVuc("5", "Khu vuc 5", "Sua")
        };

        List <LoaiHang> dslh = new List<LoaiHang>() 
        {
            new LoaiHang("01", "Ca", new List<string> { "Tram", "Thu", "Hoi" }),
            new LoaiHang("02", "Thit", new List<string> { "Heo" , "Bo", "Ga"}),
            new LoaiHang("03", "Tom", new List<string> { "Su", "Tep" }),
            new LoaiHang("04", "Trung", new List<string> { "Ga", "Vit" }),
            new LoaiHang("05", "Sua", new List<string> {"Vinamilk", "TH"})
        };

        List <MatHang> dsmh = new List<MatHang>() 
        {
            new MatHang("01.01", "Tram", "kg", 70.0, new List<string> {"Khu vuc 1"}),
            new MatHang("02.03", "Ga", "kg", 80.0, new List<string> {"Khu vuc 2", "Khu vuc 3"})
        };

        List<NhaCungCap> dsncc = new List<NhaCungCap>()
        { 
           new NhaCungCap("01", "A", "101", "Lu Gia", "ncca@gmail.com", new List<string>{"02633.9999"}, new List<string>{"Thu", "Heo", "TH"}),
           
        };


        int so;
        do
        {
            repeat:
            Console.Clear();
            Console.Write("Nhap chon: ");
            so = int.Parse(Console.ReadLine());

            switch (so) 
            {
                case 1:
                    // Xuat khu vuc
                    Console.WriteLine("Ma khu vuc".PadRight(15) + "Ten".PadRight(15) + "Chuyen".PadRight(15));
                    foreach (var kv in dskv)
                    {
                        kv.Xuat();
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    // Xuat loai hang
                    Console.WriteLine("Ma loai hang".PadRight(20) + "Ten".PadRight(15) + "Mat hang".PadRight(15));
                    foreach (var lh in dslh)
                    {
                        lh.Xuat();
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    // Xuat mat hang
                    Console.WriteLine("Ma mat hang".PadRight(20) + "Ten mat hang".PadRight(15) + "Don vi tinh".PadRight(15) + "Don gia".PadRight(15) + "Nha cung cap".PadRight(15));
                    foreach (var mh in dsmh)
                    {
                        mh.Xuat();
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    // Xuat thong tin nha cung cap
                    Console.WriteLine("Ma mat hang".PadRight(20) + "Ten mat hang".PadRight(15) + "Don vi tinh".PadRight(15) + "Don gia".PadRight(15) + "Nha cung cap".PadRight(15));
                    foreach (var ncc in dsncc)
                    {
                        ncc.Xuat();
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Thoat!");
                    break;
            }
            if (so > 0)
            {
                Console.ReadKey();
                goto repeat;
            }

        } while (so < 0 || so > 4);
    }
}



