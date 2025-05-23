using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraDe1
{
    public class DanhSachK
    {
        List<IA> ds;
        public DanhSachK()
        {
            ds = new List<IA>();
        }

        public void Them(IA a)
        {
            ds.Add(a);
        }

        public void HienThi()
        {
            Console.WriteLine("C".PadRight(10) + "X".PadRight(10) + "Y".PadRight(10));
            foreach (var k in ds)
            {
                Console.WriteLine(k);
            }
        }

        public void ThemTuHang(string a)
        {
            var s = a.Split(",");
            K k = null;
            var c = s[0];
            var x = s[1];
            var y = int.Parse(s[2]);
            if (k != null)
            {
                k = new K(c, x, y);
            }
        }

        public void DocTuFile()
        {
            string filePath = "data.txt";
            string line = "";
            StreamReader sr = new StreamReader(filePath);
            while ((line = sr.ReadLine()) != null)
            {              
                ThemTuHang(line);
            }
            sr.Close();
        }

        // 1. Dem danh sach theo IA, IB
        public int DemDSTheoIA()
        {
            int dem = 0;
            foreach (var k in ds)
                if (k is IA)
                    dem++;
            return dem;
        }

        public int DemDSTheoIB()
        {
            int dem = 0;
            foreach (var k in ds)
                if (k is IB)
                    dem++;
            return dem;
        }

        // 2. Tim cac K co gia tri Y xuat hien it nhat, nhieu nhat
        private List<int> LayDanhSachCacGiaTriY()
        {
            List<int> list = new List<int>();
            foreach (var k in ds)
                if (!list.Contains(k.Y))
                    list.Add(k.Y);
            return list;
        }
        private int DemSoLanXuatHienY(int y)
        {
            int dem = 0;
            foreach (var k in ds)
                if (k.Y == y)
                    dem++;
            return dem;
        }

        private int TimSoLanXuatHienNhieuNhat()
        {
            int max = 0;
            List<int> list = LayDanhSachCacGiaTriY();
            foreach (var y in list)
            {
                int so = DemSoLanXuatHienY(y);
                if (so > max)
                    max = so;
            }
            return max;
        }

        private int TimSoLanXuatHienItNhat()
        {
            int min = int.MaxValue;
            List<int> list = LayDanhSachCacGiaTriY();
            foreach (var y in list)
            {
                int so = DemSoLanXuatHienY(y);
                if (so < min)
                    min = so;
            }
            return min;
        }

        public DanhSachK TimCacKCoGiaTriYXuatHienNhieuNhat()
        {
            DanhSachK kq = new DanhSachK();
            int max = TimSoLanXuatHienNhieuNhat();
            foreach (var k in ds)
                if (DemSoLanXuatHienY(k.Y) == max)
                    kq.Them(k);
            return kq;
        }

        public DanhSachK TimCacKCoGiaTriYXuatHienItNhat()
        {
            DanhSachK kq = new DanhSachK();
            int min = TimSoLanXuatHienItNhat();
            foreach (var k in ds)
                if (DemSoLanXuatHienY(k.Y) == min)
                    kq.Them(k);
            return kq;
        }

        // 3. Tim cac K theo IB co chieu dai cua C dai nhat, ngan nhat
        private int TimChieuDaiCMax()
        {
            int max = 0;
            foreach (var k in ds)
            {
                int so = int.Parse(((IB)k).LayChieuDaiCuaC());
                if (so > max)
                    max = so;
            }
            return max;
        }

        private int TimChieuDaiCMin()
        {
            int min = int.MaxValue;
            foreach (var k in ds)
            {
                int so = int.Parse(((IB)k).LayChieuDaiCuaC());
                if (so < min)
                    min = so;
            }
            return min;
        }

        public DanhSachK TimCacKTheoIBCoChieuDaiMax()
        {
            int max = TimChieuDaiCMax();
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
            {
                int so = int.Parse(((IB)k).LayChieuDaiCuaC());
                if (so == max)
                    kq.Them(k);
            }

            return kq;
        }

        public DanhSachK TimCacKTheoIBCoChieuDaiMin()
        {
            int min = TimChieuDaiCMin();
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
            {
                int so = int.Parse(((IB)k).LayChieuDaiCuaC());
                if (so == min)
                    kq.Them(k);
            }

            return kq;
        }

        // Tim cac K theo gia tri cua loai
        public DanhSachK TimCacKTheoIA()
        {
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
                if (k is IA)
                    kq.Them(k);
            return kq;
        }

        public DanhSachK TimCacKTheoIB()
        {
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
                if (k is IB)
                    kq.Them(k);
            return kq;
        }

        public DanhSachK TimCacKTheoC(string c)
        {
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
                if (k is IB ib && ib.C == c)
                    kq.Them(k);
            return kq;
        }

        public DanhSachK TimCacKTheoX(string x)
        {
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
                if (k.X == x)
                    kq.Them(k);
            return kq;
        }

        public DanhSachK TimCacKTheoY(int y)
        {
            DanhSachK kq = new DanhSachK();
            foreach (var k in ds)
                if (k.Y == y)
                    kq.Them(k);
            return kq;
        }

        // Sap xep tang giam theo so khoang trang
        private void HoanVi(int i, int j, List<IA> ds)
        {
            IA tam = ds[i];
            ds[i] = ds[j];
            ds[j] = tam;
        }
        public void SapTangTheoKhoangTrang()
        {
            int t1, t2;
            for (int i = 0; i < ds.Count - 1; i++)
                for (int j = i + 1; j < ds.Count; j++)
                {
                    t1 = ((K)ds[i]).TimSoKhoangTrangChuoiC();
                    t2 = ((K)ds[j]).TimSoKhoangTrangChuoiC();
                    if (t1 > t2)
                        HoanVi(i, j, ds);
                }
        }

        public void SapGiamTheoKhoangTrang()
        {
            int t1, t2;
            for (int i = 0; i < ds.Count - 1; i++)
                for (int j = i + 1; j < ds.Count; j++)
                {
                    t1 = ((K)ds[i]).TimSoKhoangTrangChuoiC();
                    t2 = ((K)ds[j]).TimSoKhoangTrangChuoiC();
                    if (t1 < t2)
                        HoanVi(i, j, ds);
                }
        }

        // Xoa tat ca IA, IB trong danh sach
        public void XoaTatCaIA()
        {
            for (int i = 0; i < ds.Count; i++)
                if (ds[i] is IA)
                    ds.Remove(ds[i]);
        }

        public void XoaTatCaIB()
        {
            for (int i = 0; i < ds.Count; i++)
                if (ds[i] is IB)
                    ds.Remove(ds[i]);
        }

        public void XoaTatCaIA_IB()
        {
            XoaTatCaIA();
            XoaTatCaIB();
        }

        // Xoa tat ca k theo gia tri cua thuoc tinh
        public void XoaTheoC(string c)
        {
            for (int i = 0; i < ds.Count; i++)
                if (ds[i] is IB ib && ib.C == c)
                    ds.Remove(ds[i]);
        }

        public void XoaTheoX(string x)
        {
            for (int i = 0; i < ds.Count; i++)
                if (ds[i].X == x)
                    ds.Remove(ds[i]);
        }

        public void XoaTheoY(int y)
        {
            for (int i = 0; i < ds.Count; i++)
                if (ds[i].Y == y)
                    ds.Remove(ds[i]);
        }

    }
}
