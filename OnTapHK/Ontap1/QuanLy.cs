using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap1
{
    class QuanLy : NhanVien
    {
        public string Phong { get; set; }

        public QuanLy(string diaChi, string ten, int tuoi, decimal luong, string maNhanVien, string viTri, string phong)
            : base(diaChi, ten, tuoi, luong, maNhanVien, viTri)
        {
            Phong = phong;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine(Ten.PadRight(20) + DiaChi.PadRight(20) + Tuoi.ToString().PadRight(10)
                + MaNhanVien.PadRight(10) + Luong.ToString().PadRight(10) + ViTri.PadRight(10) + Phong.PadLeft(10));
        }      
    }
}
