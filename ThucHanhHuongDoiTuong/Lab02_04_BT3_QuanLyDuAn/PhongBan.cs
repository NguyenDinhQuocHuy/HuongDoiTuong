using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_04_BT3_QuanLyDuAn
{
    public class PhongBan
    {
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public NhanVien TruongPhong { get; set; }
        public DateTime NgayNhanChuc { get; set; }
        public List<string> DiaDiem { get; set; } = new List<string>();
        public List<DuAn> DanhSachDuAn { get; set; } = new List<DuAn>();

        public PhongBan(string maSo, string ten, NhanVien truongPhong, DateTime ngayNhanChuc)
        {
            MaSo = maSo;
            Ten = ten;
            TruongPhong = truongPhong;
            NgayNhanChuc = ngayNhanChuc;
        }

        public void ThemDuAn(DuAn duAn)
        {
            DanhSachDuAn.Add(duAn);
        }
    }
}
