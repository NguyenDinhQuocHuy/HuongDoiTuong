using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_04_BT3_QuanLyDuAn
{
    public class DuAn
    {
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public string DiaDiem { get; set; }
        public PhongBan PhongQuanLy { get; set; }

        public DuAn(string maSo, string ten, string diaDiem, PhongBan phongQuanLy)
        {
            MaSo = maSo;
            Ten = ten;
            DiaDiem = diaDiem;
            PhongQuanLy = phongQuanLy;
        }
    }
}
