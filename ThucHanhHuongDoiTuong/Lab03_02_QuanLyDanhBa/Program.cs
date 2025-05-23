
using Lab03_02_QuanLyDanhBa;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public enum ThucDon
    {
        // Phan 3
        Nhap = 1,
        Xuat,
        TimDSCacThanhPho,
        DemSoThueBaoTheoTP,
        TimTPCoNhieuThueBaoNhat,

        // Phan 4
        // 1. Them 1 thue bao bang tay
        Them1TBBangTay,

        // 2. Tim tat ca thanh pho co so thue bao la x
        TimTPCoSoThueBaoX,

        // 3. Tim thanh pho co it thue bao nhat
        TimTPCoItThueBaoNhat,

        // 4. Tim thue bao so huu it so dien thoai nhat
        TimThueBaoSoHuuItSDTNhat,

        // 5. Sap xep khach hang tang giam theo ho ten, so luong so dien thoai so huu
        SapTangGiamTheoHoTen_SLSDT,

        // 6. Dien thi danh sach cac thanh pho theo chieu tang, giam cua so luong thue bao
        HienThiDSTPTangGiamCuaSLThueBao,

        // 7. Hien thi danh ba theo chieu tang, giam cua cac truong trong thue bao
        DienThiDanhBaTangGiamTheoTruong,

        // 8. Bo sung thuoc tinh ngay dang ky thue bao. tim thang khong thue bao nao dang ky   
        TimThang0ThueBaoDangKy,

        // 9. Tim tat ca khach hang theo gioi tinh
        TimKhachHangTheoGioiTinh,

        // 10. Xoa tat ca khach hang thuoc mot tinh nao do
        XoaTatCaKhachHangThuoc1ThuocTinh,

        // 11. Tat ca khach hang nao sinh thang 1 thi duoc tang them 1 so dien thoai moi con so la cmnd
        TangSDTChoKhachSinhT1,

        // 12. Tim ngay co nhieu khach hang dang ky nhat, it nguoi dang ki nhat
        TimNgayCoNhieu_ItKhachDKNhat,

        // 13. Thong ke va hien thi du lieu theo tung tinh va moi tinh hien thi theo thanh pho theo mau 
        ThongKe,

        Thoat
    }

    static void Main(string[] args)
    {
        //DanhBa db = new DanhBa();
        //db.NhapTuFile();
        //db.Xuat();

        //List<string> kq = db.TimDSCacThanhPho();
        //foreach (var item in kq)
        //{
        //    Console.WriteLine($"Thanh pho {item}");
        //}

        //kq = db.TimDSCacThanhPho();
        //foreach (var item in kq)
        //{
        //    Console.WriteLine(item + " so thue bao " + db.DemSoThuebaoTheoTP(item));
        //}

        //kq = db.TimTPCoNhieuThueBaoNhat();
        //foreach (var item in kq)
        //{
        //    Console.WriteLine(item + " so thue bao lon nhat " + db.DemSoThuebaoTheoTP(item));
        //}

        DanhBa db = new DanhBa();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Chon chuc nang: ");
            Console.WriteLine($"Nhap {(int)ThucDon.Nhap} de nhap tu file");
            Console.WriteLine($"Nhap {(int)ThucDon.Xuat} de xuat danh ba");
            Console.WriteLine($"Nhap {(int)ThucDon.TimDSCacThanhPho} de tim danh sach cac thanh pho");
            Console.WriteLine($"Nhap {(int)ThucDon.DemSoThueBaoTheoTP} de tim so thue bao theo thanh pho");
            Console.WriteLine($"Nhap {(int)ThucDon.TimTPCoNhieuThueBaoNhat} tim thanh pho co nhieu thue bao nhat");
            Console.WriteLine($"Nhap {(int)ThucDon.Them1TBBangTay} de them mot thue bao bang tay (nhap thu cong)");
            Console.WriteLine($"Nhap {(int)ThucDon.TimTPCoSoThueBaoX} de tim thanh pho co so thue bao X, voi so thue bao X duoc nhap tu ban phim");
            Console.WriteLine($"Nhap {(int)ThucDon.TimTPCoItThueBaoNhat} de tim thanh pho co it thue bao nhat");
            Console.WriteLine($"Nhap {(int)ThucDon.TimThueBaoSoHuuItSDTNhat} de tim thue bao co it so dien thoai nhat");
            Console.WriteLine($"Nhap {(int)ThucDon.SapTangGiamTheoHoTen_SLSDT} de sap xep danh sach tang giam theo ho ten, so dien thoai so huu");
            Console.WriteLine($"Nhap {(int)ThucDon.Thoat} de thoat");
            ThucDon chon = (ThucDon)int.Parse(Console.ReadLine());

            
            switch (chon)
            {
                case ThucDon.Nhap:
                    db.NhapTuFile();
                    Console.WriteLine("Da nhap xong tu file");
                    break;

                case ThucDon.Xuat:
                    db.Xuat();
                    break;

                case ThucDon.TimDSCacThanhPho:
                    List<string> kq = db.TimDSCacThanhPho();
                    foreach (var item in kq)
                    {
                        Console.WriteLine($"Thanh pho {item}");
                    }
                    break;

                case ThucDon.DemSoThueBaoTheoTP:
                    List<string> kq1 = db.TimDSCacThanhPho();
                    foreach (var item in kq1)
                    {
                        Console.WriteLine(item + " so thue bao " + db.DemSoThuebaoTheoTP(item));
                    }
                    break;

                case ThucDon.TimTPCoNhieuThueBaoNhat:
                    List<string> kq2 = db.TimTPCoNhieuThueBaoNhat();
                    foreach (var item in kq2)
                    {
                        Console.WriteLine(item + " so thue bao lon nhat " + db.DemSoThuebaoTheoTP(item));
                    }
                    break;

                case ThucDon.Them1TBBangTay:
                    db.NhapThuCong();
                    break;

                case ThucDon.TimTPCoSoThueBaoX:
                    Console.Write("Nhap so thue bao: ");
                    string soTB = Console.ReadLine().Trim();
                    List<string> kq3 = db.TimTPTheoSoThueBao(soTB);
                    XuatChuoi(kq3);
                    break;

                case ThucDon.TimTPCoItThueBaoNhat:
                    List<string> kq4 = db.TimTPCoItThueBaoNhat();
                    foreach (var item in kq4)
                    {
                        Console.WriteLine(item + " so thue bao it nhat " + db.DemSoThuebaoTheoTP(item));
                    }
                    break;

                case ThucDon.TimThueBaoSoHuuItSDTNhat:
                    List<string> kq5 = db.TimThueBaoCoItSoDTNhat();
                    foreach (var item in kq5)
                    {
                        Console.WriteLine(item + " so dien thoai it nhat " + db.DemSoDienThoaiTheoThueBao(item));
                    }
                    break;

                case ThucDon.SapTangGiamTheoHoTen_SLSDT:
                    string tangGiam = "";
                    Console.Write("Ban muon sap tang hay giam ho ten (T/G): "); tangGiam = Console.ReadLine();
                    db.SapTang_GiamTheoHoTen(tangGiam);
                    Console.Write("Ban muon sap tang hay giam so luong so dien thoai so huu (T/G): "); tangGiam = Console.ReadLine();
                    db.SapTang_GiamTheoSoDTSoHuu(tangGiam);
                    db.Xuat();
                    break;




                default:
                    Console.WriteLine("Thoat chuong trinh !");
                    return;
            }
            Console.WriteLine("Nhan 1 phim de tiep tuc !");
            Console.ReadKey();
        }
    }

    static void XuatChuoi(List<string> s)
    {
        foreach (var item in s)
            Console.Write(item + "\t");
        Console.WriteLine();
    }

}



