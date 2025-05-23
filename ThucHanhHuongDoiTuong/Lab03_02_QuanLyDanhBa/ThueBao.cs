using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Lab03_02_QuanLyDanhBa
{
    public enum GioiTinh
    {
        Nam,
        Nu
    }

    public class ThueBao
    {
       
        string diaChi;
        GioiTinh gioiTinh;
        string hoTen;
        DateTime ngaySinh;
        string soDT;
        string soCMND;

        public string SoDienThoai
        {
            get { return soDT; }
            set { soDT = value.Trim(); }
        }

        public string SoCMND
        {
            get { return soCMND; }
            set { soCMND = value.Trim(); }
        }

        public string TenThueBao 
        {
            get { return hoTen; }
            set { hoTen = value.Trim(); }
        }

        public string Ten 
        { 
            get
            {
                if (string.IsNullOrWhiteSpace(TenThueBao))
                    return " ";
                string[] s = TenThueBao.Trim().Split(' ');
                return s[s.Length - 1]; // Lấy phần tử cuối cùng (Tên)
            }
        }

        public ThueBao()
        {

        }

        public ThueBao(string soCMND, string hoTen, DateTime ngaySinh, GioiTinh gioiTinh, string soDT, string diaChi)
        {
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soDT = soDT;
            this.soCMND = soCMND;
        }

        public ThueBao(string tb)
        {       
            string[] s = tb.Split(',');            
            soCMND = s[0];
            hoTen = s[1];
            ngaySinh = DateTime.ParseExact(s[2], "d/M/yyyy", CultureInfo.InvariantCulture);
            gioiTinh = (GioiTinh)((s[3] == "Nam" || s[3] == "nam") ? 0 : 1);
            soDT = s[4];
            diaChi = s[5];
        }

        public void Xuat()
        {
            Console.WriteLine(soCMND.PadRight(15) + hoTen.PadRight(20) + ngaySinh.ToString("dd/MM/yyyy").PadRight(15) + gioiTinh.ToString().PadRight(8) + soDT.PadRight(10) + diaChi.PadRight(15));
        }

        // Bổ sung thuộc tính ThanhPho trích dữ liệu từ trường (Field) diaChi
        public string ThanhPho
        {
            get
            {
                int vt = diaChi.LastIndexOf('-');
                return diaChi.Substring(vt + 1, diaChi.Length - vt - 1);
            }
        }

        
    }
}
