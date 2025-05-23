using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ontap1
{
    public class DanhSachNhanVien
    {
        List<Nguoi> collection;
        public DanhSachNhanVien()
        {
            collection = new List<Nguoi>();
        }

        public void Them(Nguoi a)
        {
            collection.Add(a);
        }

        public void Xuat()
        {
            Console.WriteLine("Ten".PadRight(20) + "Dia chi".PadRight(20) + "Tuoi".PadRight(10)
                + "Ma NV".PadRight(10) + "Luong".ToString().PadRight(10) + "Vi tri".PadRight(10) + "Phong".PadLeft(10));
            foreach (var i in collection)
            {
                Console.WriteLine();
                i.HienThiThongTin();
            }
        }

        public void NhapTuHang(string line)
        {
            // Kieu,DiaChi,Ten,Tuoi,(NhanVien)Luong,MaNhanVien,ViTri,Phong(QuanLy)
            Nguoi a = null;
            var s = line.Split(",");
            string kieu = s[0];
            string diaChi = s[1];
            string ten = s[2];
            int tuoi = int.Parse(s[3]);
            if (kieu == "N")
            {
                a = new Nguoi(diaChi, ten, tuoi);
            }

            else if (kieu == "NV" || kieu == "QL")
            {
                decimal luong = decimal.Parse(s[4].Replace("m", ""));
                string ma = s[5];
                string viTri = s[6];
                if (kieu == "NV")
                    a = new NhanVien(diaChi, ten, tuoi, luong, ma, viTri);
                else
                {
                    string phong = s[7];
                    a = new QuanLy(diaChi, ten, tuoi, luong, ma, viTri, phong);
                }
            }

            if (a != null)
                Them(a);
        }

        public void NhapTuFile()
        {
            string filePath = "data.txt";
            StreamReader sr = new StreamReader(filePath);
            var line = "";
            while ((line = sr.ReadLine()) != null)
                NhapTuHang(line);
            sr.Close();
        }

        // Tìm quản lí theo phòng
        public DanhSachNhanVien TimQuanLyTheoPhong(string phong)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach (var nv in collection)
                if ((nv is QuanLy ql) && (ql.Phong == phong))
                    kq.Them(nv);
            return kq;
        }

        public void XoaQuanLyTheoPhong(string phong) // Foreach không được phép truy cập vào phần tử, nên phải sử dụng for
        {
            for (int i = 0; i < collection.Count; i++)
                if ((collection[i] is QuanLy ql) && (ql.Phong == phong))
                    collection.Remove(collection[i]);
        }

        public void HoanVi(List<Nguoi> ds, int i, int j)
        {
            var tam = ds[i];
            ds[i] = ds[j];
            ds[j] = tam;
        }

        public enum SapXep
        { 
            Tang,
            Giam
        }

        private void SapTangTheoPhong()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (collection[i] is QuanLy ql1 && collection[j] is QuanLy ql2)
                        if (ql1.Phong.CompareTo(ql2.Phong) > 0)
                            HoanVi(collection, i, j);
        }

        private void SapGiamTheoPhong()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (collection[i] is QuanLy ql1 && collection[j] is QuanLy ql2)
                        if (ql1.Phong.CompareTo(ql2.Phong) < 0)
                            HoanVi(collection, i, j);
        }
        
        public void SapXepTheoPhong(SapXep x)
        {
            if (x == SapXep.Tang)
                SapTangTheoPhong();
            else SapGiamTheoPhong();
        }

        // Cập nhật thông tin
        private void CapNhatDiaChi(Nguoi n)
        {
            Console.Write("Cap nhat dia chi (Y/N) ?");
            var chon = Console.ReadLine();
            if (chon == "Y" || chon == "y")
            {
                Console.Write("Nhap dia chi moi: ");
                n.DiaChi = Console.ReadLine();
            }
        }

        private void CapNhatTuoi(Nguoi n)
        {
            Console.Write("Cap nhat tuoi (Y/N) ?");
            var chon = Console.ReadLine();
            if (chon == "Y" || chon == "y")
            {
                Console.Write("Nhap tuoi moi: ");
                n.Tuoi = int.Parse(Console.ReadLine());
            }
        }

        private void CapNhatLuong(NhanVien nv)
        {
            Console.Write("Cap nhat luong (Y/N) ?");
            var chon = Console.ReadLine();
            if (chon == "Y" || chon == "y")
            {
                Console.Write("Nhap luong moi: ");
                nv.Luong = decimal.Parse(Console.ReadLine());
            }
        }

        private void CapNhatViTri(NhanVien nv)
        {
            Console.Write("Doi vi tri (Y/N) ?");
            var chon = Console.ReadLine();
            if (chon == "Y" || chon == "y")
            {
                Console.Write("Nhap vi tri moi: ");
                nv.ViTri = Console.ReadLine();
            }
        }

        private void CapNhatPhong(QuanLy ql)
        {
            Console.Write("Doi phong (Y/N) ?");
            var chon = Console.ReadLine();
            if (chon == "Y" || chon == "y")
            {
                Console.Write("Nhap phong moi: ");
                ql.Phong = Console.ReadLine();
            }
        }


        public void CapNhatThongTin(string ma)
        {
            foreach (var i in collection)
                if (i is NhanVien nv && nv.MaNhanVien == ma)
                {
                    CapNhatDiaChi(nv);
                    CapNhatTuoi(nv);
                    CapNhatDiaChi(nv);
                    CapNhatLuong(nv);
                    CapNhatViTri(nv);

                    if (i is QuanLy ql)
                        CapNhatPhong(ql);
                    Console.WriteLine("Cap nhat xong !");
                    return;
                }
        }
        
    }
}
