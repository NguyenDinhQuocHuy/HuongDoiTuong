using Lab02_04_BT3_QuanLyDuAn;

class Program
{
    static void Main()
    {
        // Tạo công ty
        CongTy congTy = new CongTy { Ten = "ABC Corp" };

        // Tạo nhân viên
        NhanVien truongPhong = new NhanVien("NV001", "Nguyen Van A", "Da Lat", 15000000, "Nam", new DateTime(1985, 5, 10), null);

        // Tạo phòng ban và gán trưởng phòng
        PhongBan phongIT = new PhongBan("PB001", "IT", truongPhong, DateTime.Now);
        truongPhong.PhongBan = phongIT;

        // Thêm phòng vào công ty
        congTy.ThemPhongBan(phongIT);

        // Tạo dự án
        DuAn duAn1 = new DuAn("DA001", "Phat trien Web", "Da Lat", phongIT);
        phongIT.ThemDuAn(duAn1);

        // Tạo nhân viên mới và gán quản lý trực tiếp
        NhanVien nhanVien1 = new NhanVien("NV002", "Tran Van B", "HCM", 12000000, "Nam", new DateTime(1990, 7, 15), phongIT);
        nhanVien1.QuanLyTrucTiep = truongPhong;

        // Nhân viên tham gia dự án
        nhanVien1.ThamGiaDuAn(duAn1, 20);

        // Thêm thân nhân cho nhân viên
        ThanNhan thanNhan1 = new ThanNhan("Tran Thi C", "Nu", new DateTime(2010, 3, 25), "Con gai");
        nhanVien1.ThemThanNhan(thanNhan1);

        // In thông tin
        Console.WriteLine($"Cong ty: {congTy.Ten}");
        Console.WriteLine($"Phong Ban: {phongIT.Ten} - Truong phong: {truongPhong.HoTen}");
        Console.WriteLine($"Du an: {duAn1.Ten} - Dia diem: {duAn1.DiaDiem}");
        Console.WriteLine($"Nhan viên: {nhanVien1.HoTen} - Quan ly: {nhanVien1.QuanLyTrucTiep.HoTen}");
        Console.WriteLine($"Than nhan cua {nhanVien1.HoTen}: {thanNhan1.HoTen} ({thanNhan1.MoiQuanHe})");
    }
}
