using Lab03_01_QuanLySinhVien;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        /*
        Bước 1: Tạo tập tin SinhVien.cs chứa lớp SinhVien, tạo 5 đối tượn và in kết quả ra màn hình
        DanhSachSinhVien dssv = new DanhSachSinhVien();
        SinhVien sv1 = new SinhVien("001", "Quoc Huy", 8.5f, true, "CTK48B");
        SinhVien sv2 = new SinhVien("002", "Dang Huy", 8.7f, true, "CTK48B");
        SinhVien sv3 = new SinhVien("003", "Bao Long", 8.5f, true, "CTK48B");
        SinhVien sv4 = new SinhVien("004", "Phuc Lam", 9.0f, true, "CTK48B");
        SinhVien sv5 = new SinhVien("005", "Huu Phuc", 8.5f, true, "CTK48B");

        List<SinhVien> list = new List<SinhVien>()
        {
            sv1, sv2, sv3, sv4, sv5
        };

        foreach (var i in list)       
            dssv.AddStudent(i);
        Console.WriteLine(dssv);

        Bước 2: Tạo tập tin DanhSachSinhVien.cs chứa lớp DanhSachSinhVien
        Tạo 5 đối tượng sinh viên và hiển thị kết quả ra màn hình, tạo tập tin data.txt       
        ds.ReadFromFile();
        Console.WriteLine(ds);
        Console.ReadKey();

        Bước 3: Bổ sung các phương thức, chạy kiểm tra
        */
        DanhSachSinhVien ds = new DanhSachSinhVien();
        ds.ReadFromFile();
        int so, soLuong;
        string lop, kieuSX, hocLuc, sL;
        List<string> listLop = new List<string>();
        List<string> dsLop = ds.LayDanhSachLop();

        do
        {
        repeat:
            Console.Clear();
            XuatMenu();
            Console.Write("Nhap chon: ");
            so = int.Parse(Console.ReadLine());

            switch (so)
            {
                case 1:
                    Console.Write("Nhap lop: ");
                    lop = Console.ReadLine();
                    soLuong = ds.DemSoLuongSVNam(lop);
                    Console.WriteLine($"So luong sinh vien nam trong lop {lop} la: {soLuong}");
                    break;

                case 2:
                    Console.Write("Nhap lop: ");
                    lop = Console.ReadLine();
                    soLuong = ds.DemSoLuongSVNu(lop);
                    Console.WriteLine($"So luong sinh vien nu trong lop {lop} la: {soLuong}");
                    break;

                case 3:
                    Console.Write("Chon kieu sap xep (Tang/Giam): ");
                    kieuSX = Console.ReadLine();
                    if (kieuSX == "t" || kieuSX == "T" || kieuSX == "tang" || kieuSX == "Tang")
                    {
                        Console.WriteLine("Sap tang");
                        ds.SapXepTangTheoDTB();
                        Console.WriteLine(ds);
                    }

                    if (kieuSX == "g" || kieuSX == "G" || kieuSX == "giam" || kieuSX == "Giam")
                    {
                        Console.WriteLine("Sap giam");
                        ds.SapXepGiamTheoTB();
                        Console.WriteLine(ds);
                    }
                    
                    break;
                case 4:
                    DanhSachSinhVien kq = new DanhSachSinhVien();
                    kq = ds.TimDSSVCoDiemTBCaoNhat();
                    Console.WriteLine(kq);
                    break;

                case 5:
                    listLop = ds.TimLopCoDTBCaoNhat();
                    Console.Write("Lop co sinh vien co diem trung binh cao nhat la: ");
                    Xuat(listLop);
                    break;

                case 6:
                    listLop = ds.TimLopKhongCoDTBCaoNhat();
                    Console.Write("Lop co sinh vien khong co diem trung binh cao nhat la: ");
                    Xuat(listLop);
                    break;

                case 7:
                    foreach (var tenLop in dsLop)
                    {
                        Console.WriteLine($"Danh sach sinh vien lop {tenLop}: ");
                        ds.SapXepGiamTheoTB();
                        Console.WriteLine(ds.DanhSachSVCua1Lop(tenLop).ToString());
                        Console.WriteLine();
                    } 
                    break;

                case 8:
                    foreach(var tenLop in ds.LayDanhSachLop())
                    {
                        Console.WriteLine($"\n Xếp hạng sinh viên lớp {tenLop}:");
                        Console.WriteLine(ds.XepHangSinhVienCuaLop(tenLop).ToString());
                    }
                    break;

                case 9:
                    Console.WriteLine("Lop co tong diem trung binh cao nhat: " + ds.TimLopCoTongDTBCaoNhat());
                    Console.WriteLine("Lop co tong diem trung binh thap nhat: " + ds.TimLopCoTongDTBThapNhat());
                    break;

                case 10:
                    Console.WriteLine("Lop có nhieu sinh vien gioi nhat: " + ds.TimLopNhieuSinhVienLoai("Giỏi"));
                    break;

                case 11:
                    Console.Write("Nhap It / Nhieu: ");
                    sL = Console.ReadLine();
                    Console.Write("Nhap hoc luc (Gioi / Kha / TB / Yeu): ");
                    hocLuc = Console.ReadLine();

                    if (sL == "nhieu" || sL == "Nhieu")
                    {
                        if (hocLuc == "Gioi" || hocLuc == "gioi")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopNhieuSinhVienLoai("Gioi"));
                        if (hocLuc == "Kha" || hocLuc == "kha")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopNhieuSinhVienLoai("Kha"));
                        if (hocLuc == "TB" || hocLuc == "tb")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopNhieuSinhVienLoai("Trung binh"));
                        if (hocLuc == "Yeu" || hocLuc == "yeu")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopNhieuSinhVienLoai("Yeu"));
                    }

                    if (sL == "It" || sL == "it")
                    {
                        if (hocLuc == "Gioi" || hocLuc == "gioi")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopItSinhVienLoai("Gioi"));
                        if (hocLuc == "Kha" || hocLuc == "kha")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopItSinhVienLoai("Kha"));
                        if (hocLuc == "TB" || hocLuc == "tb")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopItSinhVienLoai("Trung binh"));
                        if (hocLuc == "Yeu" || hocLuc == "yeu")
                            Console.WriteLine($"Lop có {sL} sinh vien {hocLuc} nhat: " + ds.TimLopItSinhVienLoai("Yeu"));
                    }


                    break;

                case 12:
                    var fileName = "DanhSachLop.txt";
                    ds.GhiDanhSachLopXuongFile(fileName);
                    Console.WriteLine($"Đa ghi danh sach lop vao file {fileName} !");
                    break;

                case 13:
                    Console.WriteLine("Lop khong co sinh vien nu: " + string.Join(", ", ds.TimLopKhongCoSinhVienNu()));                   
                    break;

                case 14:
                    Console.WriteLine("Lop khong co sinh vien nam: " + string.Join(", ", ds.TimLopKhongCoSinhVienNam()));
                    break;

                case 15:
                    foreach (var i in ds.DemSoLuongSinhVienTheoLop())
                    {
                        Console.WriteLine($"Lop {i.Key}: {i.Value} sinh viên");
                    }
                    break;

                case 16:
                    Console.Write("Nhap ten lop can xoa: ");
                    string lopXoa = Console.ReadLine();
                    if (dsLop.Contains(lopXoa))
                    {
                        ds.XoaTatCaSinhVienCuaLop(lopXoa);
                        Console.WriteLine($"Da xoa tat ca sinh vien cua lop {lopXoa} !");
                    }
                    break;

                case 17:
                    foreach (var kv in ds.XepLoaiTatCaSinhVien())
                    {
                        Console.WriteLine($"MSSV {kv.Key}: {kv.Value}");
                    }
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

        } while (so < 0 || so > 17);



        static void XuatMenu()
        {

            Console.WriteLine("==================== CHON CHUC NANG ====================");
            Console.WriteLine(" 0. Thoat chuong trinh");
            Console.WriteLine(" 1. Dem so luong sinh vien nam trong lop");
            Console.WriteLine(" 2. Dem so luong sinh vien nu trong lop");
            Console.WriteLine(" 3. Hien thi danh sach sinh vien theo chieu tang, giam cua diem trung binh");
            Console.WriteLine(" 4. Tim danh sach sinh vien co diem trung binh cao nhat");
            Console.WriteLine(" 5. Tim lop co sinh vien co diem trung binh cao nhat");
            Console.WriteLine(" 6. Tim lop co sinh vien khong co diem trung binh cao nhat");
            Console.WriteLine(" 7. Hien thi danh sach sinh vien theo lop va theo chieu giam cua diem trung binh");
            Console.WriteLine(" 8. Xep hang sinh vien cua lop");
            Console.WriteLine(" 9. Tim lop co tong diem trung binh cao nhat, thap nhat");
            Console.WriteLine("10. Tim lop co nhieu sinh vien gioi nhat");
            Console.WriteLine("11. Tim lop co nhieu (hoac it) sinh vien theo loai yeu, trung binh, kha");
            Console.WriteLine("12. Ghi xuong file danh sach lop");
            Console.WriteLine("13. Tim lop khong co sinh vien nu");
            Console.WriteLine("14. Tim lop khong co sinh vien nam");
            Console.WriteLine("15. Dem so luong sinh vien theo lop");
            Console.WriteLine("16. Xoa tat ca sinh vien cua lop nao do");
            Console.WriteLine("17. Xep loai sinh vien dua tren diem trung binh");
            Console.WriteLine();
        }

        static void Xuat(List <string> ds)
        {
            foreach (var i in ds)
                Console.Write(i + " ");
            Console.WriteLine();             
        }
    }              
}
