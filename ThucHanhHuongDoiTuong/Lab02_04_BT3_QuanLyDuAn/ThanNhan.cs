using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_04_BT3_QuanLyDuAn
{
    public class ThanNhan
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MoiQuanHe { get; set; }

        public ThanNhan(string hoTen, string gioiTinh, DateTime ngaySinh, string moiQuanHe)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            MoiQuanHe = moiQuanHe;
        }
    }
}
