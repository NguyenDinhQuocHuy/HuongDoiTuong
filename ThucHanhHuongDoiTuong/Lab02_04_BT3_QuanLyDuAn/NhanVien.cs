using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_04_BT3_QuanLyDuAn
{
    public class NhanVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public decimal Luong { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public PhongBan PhongBan { get; set; }
        public NhanVien QuanLyTrucTiep { get; set; }
        public List<ThanNhan> DanhSachThanNhan { get; set; } = new List<ThanNhan>();
        public Dictionary<DuAn, int> GioLamViec { get; set; } = new Dictionary<DuAn, int>();
/*
         1. public → Thuộc tính này có thể được truy cập từ bên ngoài class.
         2. Dictionary<DuAn, int> → Đây là một Dictionary (từ điển) với:
         3. DuAn (key): Đối tượng dự án (DuAn) mà nhân viên tham gia.
         4. int (value): Số giờ làm việc của nhân viên trên dự án đó.
         5. { get; set; } → Cung cấp getter và setter để có thể truy cập và thay đổi giá trị của GioLamViec.
         6. = new Dictionary<DuAn, int>(); → Khởi tạo một Dictionary rỗng khi object được tạo.
*/

        public NhanVien(string maSo, string hoTen, string diaChi, decimal luong, string gioiTinh, DateTime ngaySinh, PhongBan phongBan)
        {
            MaSo = maSo;
            HoTen = hoTen;
            DiaChi = diaChi;
            Luong = luong;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            PhongBan = phongBan;
        }

        public void ThemThanNhan(ThanNhan thanNhan)
        {
            DanhSachThanNhan.Add(thanNhan);
        }

        public void ThamGiaDuAn(DuAn duAn, int soGio)
        {
            // Cap nhat so gio lam viec tu dictionary 
            GioLamViec[duAn] = soGio;
        }
    }
}
