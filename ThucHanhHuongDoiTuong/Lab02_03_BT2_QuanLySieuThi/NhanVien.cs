using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_03_BT2_QuanLySieuThi
{
    class NhanVien
    {   
        string maKV;
        string maNV;
        string hoTen;
        DateTime ngaySinh;
        string diaChi;
        string soDT;
        DateTime ngayVaoLam;
        string soCMND;

        public NhanVien()
        {
            
        }

        public NhanVien(string maKV, string maNV, string hoTen, DateTime ngaySinh,
            string diaChi, string soDT, DateTime ngayVaoLam, string soCMND)
        {
            this.maKV = maKV;
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.ngayVaoLam = ngayVaoLam;
            this.soCMND = soCMND;
        }
    }
}
