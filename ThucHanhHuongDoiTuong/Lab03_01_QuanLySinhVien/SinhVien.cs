using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_QuanLySinhVien
{
    public class SinhVien
    {
        public string maSV;
        public string hoTen;
        public float dTB;
        public Boolean gioiTinh;
        private string lop;

        public string Lop 
        {
            get { return lop; }
            set { lop = value.Trim(); }
        }

        public SinhVien()
        {
            maSV = "1";
            hoTen = "a";
        }

        public SinhVien(string ma, string ho, float dtb, bool gt, string lop)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            gioiTinh = gt;
            this.lop = lop;
        }

        public SinhVien(string line)
        {
            // 001,Nguyen Van A,8.0,Nam,CTK43
            string[] str = line.Split(',');
            maSV = str[0];
            hoTen = str[1];
            dTB = float.Parse(str[2]);
            gioiTinh = str[3] == "Nam" ? true : false;
            lop = str[4];
        }

        public override string ToString()
        {
            return string.Format("{0, 0} {1, 14} {2, 6} {3, 8} {4, 13}", maSV, hoTen, dTB, gioiTinh == true ? "Nam" : "Nu", lop); 
            // {0, 1} : 0: Đối tượng, 1: Độ rộng chỉ định
        }

        public string XepLoai()
        {
            if (dTB >= 8.0) return "Gioi";
            if (dTB >= 6.5) return "Kha";
            if (dTB >= 5.0) return "Trung binh";
            return "Yeu";
        }
    }
}
