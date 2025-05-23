using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_02_QuanLyDanhBa
{
    public class DanhBa
    {
        List<ThueBao> collection = new List<ThueBao>();

        public void Xuat()
        {
            foreach (var item in collection)
            {
                item.Xuat();
            }
        }

        public void Them(ThueBao n)
        {
            collection.Add(n);
        }

        public void NhapTuFile()
        {
            string tenFile = "data.csv";
            StreamReader sr = new StreamReader(tenFile);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                ThueBao n = new ThueBao(s);
                collection.Add(n);
            }
        }

        // Tìm danh sách thành phố
        public List<string> TimDSCacThanhPho()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if (!kq.Contains(item.ThanhPho))
                    kq.Add(item.ThanhPho);
            }
            return kq;
        }

        // Đếm số thuê bao theo thành phố
        public int DemSoThuebaoTheoTP(string tp)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item.ThanhPho == tp)
                    dem++;
            }
            return dem;
        }

        public List<string> TimTPCoNhieuThueBaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            int max = int.MinValue;

            foreach (var item in dstp)
            {
                if (max < DemSoThuebaoTheoTP(item))
                    max = DemSoThuebaoTheoTP(item);
            }

            foreach (var tp in dstp)
            {
                if (DemSoThuebaoTheoTP(tp) == max)
                    kq.Add(tp);
            }

            return kq;
        }

        // Phan 4
        // Them 1 thue bao bang tay
        public void NhapThuCong()
        {
            // 12345,Nguyen Van A,11 / 2 / 1990,Nam,123456,1 PDTV - Da Lat
            while (true)
            {
                Console.WriteLine("Nhap thong tin theo dinh dang SoCMND,HoTen,NgaySinh (dd/MM/yyyy),GioiTinh,SoDT,DiaChi");
                string line = Console.ReadLine().Trim();
                string[] a = line.Split(',');
                if (a.Length == 6)
                {                   
                    ThueBao tb = new ThueBao(line);
                    Them(tb);
                    break;
                }
                else
                {
                    Console.WriteLine("Hay nhap theo dung dinh dang !");
                }
            }
        }

        // Tim thanh pho co so thue bao x
        public List<string> TimTPTheoSoThueBao(string soTB)
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if (item.SoDienThoai == soTB && !kq.Contains(item.ThanhPho))
                    kq.Add(item.ThanhPho);
            }
            return kq;
        }

        // Tim thanh pho co it thue bao nhat
        public List<string> TimTPCoItThueBaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            int min = int.MaxValue;

            foreach (var item in dstp)
            {
                if (min > DemSoThuebaoTheoTP(item))
                    min = DemSoThuebaoTheoTP(item);
            }

            foreach (var tp in dstp)
            {
                if (DemSoThuebaoTheoTP(tp) == min)
                    kq.Add(tp);
            }

            return kq;
        }

        // Tim thue bao so huu it so dien thoai nhat
        public List<string> TimDSSoCMND()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if (!kq.Contains(item.SoCMND))
                    kq.Add(item.SoCMND);
            }
            return kq;
        }

        
        public int DemSoDienThoaiTheoThueBao(string so) // Dem so dien thoai theo so CMND
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item.SoCMND == so)
                    dem++;
            }
            return dem;
        }

        public List<string> TimThueBaoCoItSoDTNhat()
        {
            List<string> kq = new List<string>();
            List<string> dsCMND = TimDSSoCMND();
            int min = int.MaxValue;

            foreach (var item in dsCMND)
            {
                if (min > DemSoDienThoaiTheoThueBao(item))
                    min = DemSoDienThoaiTheoThueBao(item);
            }

            foreach (var so in dsCMND)
            {
                if (DemSoDienThoaiTheoThueBao(so) == min)
                    kq.Add(so);
            }

            return kq;
        }

        // Sap xep khach hang tang giam theo ho ten, so luong so dien thoai so huu
/*
        int result = a.CompareTo(b);
        Nếu result == 0 → hai chuỗi giống nhau.
        Nếu result < 0 → chuỗi a < chuỗi b (về thứ tự từ điển).
        Nếu result > 0 → chuỗi a > chuỗi b
*/
        public void SapTang_GiamTheoHoTen(string chon)
        {      
            if (chon == "t" || chon == "T")
                for (int i = 0; i < collection.Count - 1; i++)
                    for (int j = i + 1; j < collection.Count; j++)
                    {
                        int dk = collection[i].TenThueBao.CompareTo(collection[j].TenThueBao);
                        if (dk > 0)
                        {
                            ThueBao temp = collection[i];
                            collection[i] = collection[j];
                            collection[j] = temp;
                        }
                    }

            if (chon == "G" || chon == "g")
                for (int i = 0; i < collection.Count - 1; i++)
                    for (int j = i + 1; j < collection.Count; j++)
                    {
                        int dk = collection[i].TenThueBao.CompareTo(collection[j].TenThueBao);
                        if (dk < 0)
                        {
                            ThueBao temp = collection[i];
                            collection[i] = collection[j];
                            collection[j] = temp;
                        }                      
                    }
        }

        private bool SoSanhHoTen(string a, string b) // Kiem tra ho ten co khac nhau khong ?
        {
            if (a.CompareTo(b) != 0) return true;
            else return false;
        }

        private bool SoSanhTen(string a, string b) // Kiem tra ten co khac nhau khong
        {
            if (a.CompareTo(b) != 0) return true;
            else return false;
        }

        // Ham hoan vi 2 thue bao
        private void HoanVi2ThueBao(List<ThueBao> ds, int i, int j)
        {
            ThueBao tam = ds[i];
            ds[i] = ds[j];
            ds[j] = tam;
        }

        // Sắp tăng giảm theo họ tên, số lượng số điện thoại sở hữu
        private void SapTangTheoSoDTSoHuu()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if ((DemSoDienThoaiTheoThueBao(collection[i].SoCMND) > DemSoDienThoaiTheoThueBao(collection[j].SoCMND)) 
                        || SoSanhHoTen(collection[i].TenThueBao, collection[j].TenThueBao) == true)
                        HoanVi2ThueBao(collection, i, j);
        }

        private void SapGiamTheoSoDTSoHuu()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if ((DemSoDienThoaiTheoThueBao(collection[i].SoCMND) < DemSoDienThoaiTheoThueBao(collection[j].SoCMND)) 
                        || SoSanhHoTen(collection[i].TenThueBao, collection[j].TenThueBao) == true)                 
                        HoanVi2ThueBao(collection, i, j);
        }

        public void SapTang_GiamTheoSoDTSoHuu(string chon)
        {
            if (chon == "T" || chon == "t")
                SapTangTheoSoDTSoHuu();

            if (chon == "G" || chon == "g")
                SapGiamTheoSoDTSoHuu();
                 
        }

        // Ham hoan vi 2 string (chuoi)
        public void HoanViString(List<string> collection, int a, int b)
        {
            string c = collection[a];
            collection[a] = collection[b];
            collection[b] = c;
        }

        // Hiển thị danh bạ theo chiều tăng, giảm của số điện thoại sở hữu
        private List<string> XepDSTPTangTheoSLThueBao()
        {
            List<string> dstp = TimDSCacThanhPho();
            for (int i = 0; i < dstp.Count - 1; i++)
                for (int j = i + 1; j < dstp.Count; j++)
                    if (DemSoThuebaoTheoTP(dstp[i]) > DemSoThuebaoTheoTP(dstp[j]))
                        HoanViString(dstp, i, j);
            return dstp;
        }

        private List<string> XepDSTPGiamTheoSLThueBao()
        {
            List<string> dstp = TimDSCacThanhPho();
            for (int i = 0; i < dstp.Count - 1; i++)
                for (int j = i + 1; j < dstp.Count; j++)
                    if (DemSoThuebaoTheoTP(dstp[i]) < DemSoThuebaoTheoTP(dstp[j]))
                        HoanViString(dstp, i, j);
            return dstp;
        }

        public List<string> XepDSTPTangGiamTheoSLThueBao(string chon)
        {
            List<string> dskq = new List<string>();
            if (chon == "T" || chon == "t")
                dskq = XepDSTPTangTheoSLThueBao();
            else if (chon == "G" || chon == "g")
                dskq = XepDSTPGiamTheoSLThueBao();
            return dskq;
        }


    }
}
