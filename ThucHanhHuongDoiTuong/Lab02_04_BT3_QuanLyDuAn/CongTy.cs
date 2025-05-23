using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_04_BT3_QuanLyDuAn
{
    public class CongTy
    {
        public string Ten { get; set; }
        public List<PhongBan> DanhSachPhongBan { get; set; } = new List<PhongBan>();

        public void ThemPhongBan(PhongBan phongBan)
        {
            DanhSachPhongBan.Add(phongBan);
        }
    }
}
