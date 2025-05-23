using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap1
{
    public class NhanVien : Nguoi
    {
        public decimal Luong { get; set; }
        public string MaNhanVien { get; set; }
        public string ViTri { get; set; }

        public NhanVien(string diaChi, string ten, int tuoi, decimal luong, string maNhanVien, string viTri) : base(diaChi, ten, tuoi)
        {
            Luong = luong;
            MaNhanVien = maNhanVien;
            ViTri = viTri;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine(Ten.PadRight(20) + DiaChi.PadRight(20) + Tuoi.ToString().PadRight(10) 
                + MaNhanVien.PadRight(10) + Luong.ToString().PadRight(10) + ViTri.PadRight(10));
        }
    }
}
