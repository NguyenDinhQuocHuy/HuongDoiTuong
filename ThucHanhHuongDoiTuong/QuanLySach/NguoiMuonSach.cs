using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02_BT1_ThuVien
{
    internal class NgayThang
    {
        uint ngay;
        uint thang;
        uint nam;
        public NgayThang()
        {
            ngay = 1;
            thang = 1;
            nam = 1;
        }

        public NgayThang(uint ngay, uint thang, uint nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }
    }
    internal class TTLanMuon
    {
        NgayThang ngayMuon = new NgayThang();
        NgayThang ngayTra = new NgayThang();
        public TTLanMuon()
        {

        }

        public TTLanMuon(NgayThang ngayMuon, NgayThang ngayTra)
        {
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
        }
    }
    internal class NguoiMuonSach
    {
        public string soThe;
        public string hoTen;
        public string diaChi;
        public string soDT;
        TTLanMuon tt = new TTLanMuon();

        public NguoiMuonSach()
        {

        }

        public NguoiMuonSach(string soThe, string hoTen, string diaChi, string soDT, TTLanMuon tt)
        {
            this.soThe = soThe;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.tt = tt;
        }

        public void Nhap()
        {
            Console.Write("Nhap so the: ");
            soThe = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhap SDT: ");
            soDT = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"So the: {soThe}");
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine($"SDT: {soDT}");
            
        }
    }
}
