using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01_QuanLySinhVien
{
    public class DanhSachSinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();

        // Thêm một sinh viên vào danh sách sinh viên
        public void AddStudent(SinhVien sv)
        {
            ds.Add(sv);
        }

        // Đọc dữ liệu từ file data.txt
        public void ReadFromFile()
        {
            var fileName = "data.txt"; // Tên file chứa dữ liệu
            using (StreamReader sr = new StreamReader(fileName)) // Mở file để đọc
            {
                var line = "";
                while ((line = sr.ReadLine()) != null) // Đọc từng dòng trong file cho đến khi hết
                    AddStudent(new SinhVien(line)); // Tạo đối tượng SinhVien từ dòng đọc được và thêm vào danh sách
            }

            /*
            Đọc dữ liệu từ file data.txt và thêm từng sinh viên vào danh sách.
            Sử dụng StreamReader để đọc file.
            Dữ liệu từng dòng trong file sẽ được truyền vào constructor của SinhVien để tạo đối tượng. 
            */
        }

        // Xuất danh sách sinh viên
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Tạo đối tượng StringBuilder để tối ưu hiệu suất xử lý chuỗi
            sb.Append("MSSV".PadRight(6) + "Ho ten".PadRight(16) + "DTB".PadRight(5) + "  Gioi tinh" + "Lop \n".PadLeft(10));
            sb.Append("================================================= \n");
            foreach (var sv in ds)
                sb.Append(sv + "\n"); // // Thêm từng sinh viên vào chuỗi kết quả

            return sb.ToString();
        }

        // Tìm điểm trung bình cao nhất
        public float TimDiemTBCaoNhat()
        {
            return ds.Max(x => x.dTB); // Trả về điểm trung bình lớn nhất trong danh sách
        }

        // Tìm danh sách sinh viên có điểm trung bình cao nhất
        public DanhSachSinhVien TimDSSVCoDiemTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            float max = TimDiemTBCaoNhat(); // Lấy điểm trung bình cao nhất
            foreach (var item in ds)
                if (item.dTB == max)
                    kq.AddStudent(item); // Thêm sinh viên có điểm trung bình cao nhất vào danh sách
            return kq;
        }
        
        // Đếm số lượng sinh viên
        private int DemSoLuongSVTheoGioiTinhVaLop(bool GT, string lop)
        {
            return ds.Count(x => x.gioiTinh == GT && x.Lop == lop); // Trả về số lượng sinh viên theo giới tính và lớp
        }

        public int DemSoLuongSVNam(string lop)
        {
            return DemSoLuongSVTheoGioiTinhVaLop(true, lop); // Trả về số lượng sinh viên nam
        }

        public int DemSoLuongSVNu(string lop)
        {
            return DemSoLuongSVTheoGioiTinhVaLop(false, lop); // Trả về số lượng sinh viên nữ
        }

        // Lấy danh sách lớp
        public List<string> LayDanhSachLop()
        {
            List<string> kq = new List<string>();
            foreach (var sv in ds)
            {
                if (!kq.Contains(sv.Lop))
                    kq.Add(sv.Lop); // Thêm lớp vào danh sách nếu chưa có
            }
            return kq;
        }

        // Tối ưu hóa bằng LINQ
        public List<string> LayDanhSachLop_2()
        {
            return ds.Select(sv => sv.Lop).Distinct().ToList();
        }


        // Sắp xếp danh sách lớp tăng giảm theo điểm trung bình
        public enum KieuSapXep // Khai báo enum KieuSapXep với 2 kiểu tăng và giảm theo điểm trung bình
        { 
            TangDTB, 
            GiamDTB
        }

        void SapXep(KieuSapXep kieu)
        {        
            if (kieu == KieuSapXep.TangDTB)
                ds.Sort((sv1, sv2) => sv1.dTB.CompareTo(sv2.dTB)); // Sắp xếp tăng dần

            if (kieu == KieuSapXep.GiamDTB)
                ds.Sort((sv1, sv2) => -sv1.dTB.CompareTo(sv2.dTB)); // Sắp xếp giảm dần
        }

        // Sắp tăng
        public void SapXepTangTheoDTB()
        {
            SapXep(KieuSapXep.TangDTB);
        }

        // Sắp giảm
        public void SapXepGiamTheoTB()
        {
            SapXep(KieuSapXep.GiamDTB);
        }

        // Tìm lớp có điểm trung bình cao nhất
        public List<string> TimLopCoDTBCaoNhat()
        {
            List<string> lopDiemCao = new List<string>();
            float max = TimDiemTBCaoNhat(); // Gọi hàm tìm điểm trung bình cao nhất
            foreach (var i in ds) // Duyệt từng sinh viên trong danh sách sinh viên
            {
                if (i.dTB == max && !lopDiemCao.Contains(i.Lop)) // Nếu điểm trung bình của sinh viên đó bằng max và lớp không xuất hiện  
                    lopDiemCao.Add(i.Lop);
            }
            return lopDiemCao;
        }

        public List<string> TimLopKhongCoDTBCaoNhat()
        {
            List<string> lopDiemCao = TimLopCoDTBCaoNhat();
            List<string> lopKoCao = new List<string>();
            foreach (var i in ds)
            {
                if (!lopDiemCao.Contains(i.Lop) && !lopKoCao.Contains(i.Lop))
                    lopKoCao.Add(i.Lop);        
            }
            return lopKoCao;
        }

        int TimViThuCuaSV(SinhVien sv)
        {
            int vt = -1;
            foreach (var i in ds)
                if (sv.Lop == i.Lop && sv.dTB < i.dTB)
                    vt++;
            return vt;
        }

        // Xuất danh sách sinh viên của 1 lớp
        public DanhSachSinhVien DanhSachSVCua1Lop(string tenLop)
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var sv in ds)
                if (sv.Lop == tenLop)
                    kq.AddStudent(sv);
            return kq;
        }

        // Xếp hạng sinh viên của 1 lớp
        public DanhSachSinhVien XepHangSinhVienCuaLop(string tenLop)
        {
            DanhSachSinhVien kq = DanhSachSVCua1Lop(tenLop);
            kq.ds.Sort((sv1, sv2) => sv2.dTB.CompareTo(sv1.dTB));
            return kq;
        }

        // Tìm lớp có điểm trung bình cao nhất, thấp nhất
        private float TinhTongDTB(string lop)
        {
            DanhSachSinhVien dsLop = DanhSachSVCua1Lop(lop);
            float tong = 0;
            foreach (var sv in dsLop.ds)
                tong += sv.dTB;
            return tong;
        }

        private string TimLopTheoTongDTB(bool timMax)
        {
            string lopKetQua = "";
            float diemSoSanh = timMax ? float.MinValue : float.MaxValue;

            foreach (var lop in LayDanhSachLop())
            {
                float tong = TinhTongDTB(lop);
                if ((timMax && tong > diemSoSanh) || (!timMax && tong < diemSoSanh))
                {
                    diemSoSanh = tong;
                    lopKetQua = lop;
                }
            }

            return lopKetQua;
        }

        public string TimLopCoTongDTBCaoNhat()
        {
            return TimLopTheoTongDTB(true);
        }

        public string TimLopCoTongDTBThapNhat()
        {
            return TimLopTheoTongDTB(false);
        }

        // Tìm lớp có nhiều hoặc ít sinh viên theo loại yếu, trung bình, khá, giỏi
        private int DemSinhVienLoai(string lop, string loai)
        {
            DanhSachSinhVien dsLop = DanhSachSVCua1Lop(lop);
            int count = 0;
            foreach (var sv in dsLop.ds)
                if (sv.XepLoai() == loai) count++;
            return count;
        }

        private string TimLopTheoSoLuongSinhVienLoai(string loai, bool timMax)
        {
            string lopKetQua = "";
            int soSanh = timMax ? int.MinValue : int.MaxValue;

            foreach (var lop in LayDanhSachLop())
            {
                int count = DemSinhVienLoai(lop, loai);
                if ((timMax && count > soSanh) || (!timMax && count < soSanh))
                {
                    soSanh = count;
                    lopKetQua = lop;
                }
            }

            return lopKetQua;
        }

        public string TimLopNhieuSinhVienLoai(string loai)
        {
            return TimLopTheoSoLuongSinhVienLoai(loai, true);
        }

        public string TimLopItSinhVienLoai(string loai)
        {
            return TimLopTheoSoLuongSinhVienLoai(loai, false);
        }

        // Ghi danh sách lớp xuống file
        public void GhiDanhSachLopXuongFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var lop in LayDanhSachLop())
                {
                    sw.WriteLine("Lop: " + lop);
                    sw.WriteLine("=================================================");
                    sw.WriteLine(DanhSachSVCua1Lop(lop).ToString());
                }
            }
        }

        // Tìm lớp không có sinh viên nữ / nam
        private bool KiemTraLopKhongCoGioiTinh(string lop, bool gioiTinh)
        {
            DanhSachSinhVien dsLop = DanhSachSVCua1Lop(lop);
            foreach (var sv in dsLop.ds)
                if (sv.gioiTinh == gioiTinh) return false;
            return true;
        }

        public List<string> TimLopKhongCoSinhVienNu()
        {
            List<string> kq = new List<string>();
            foreach (var lop in LayDanhSachLop())
                if (KiemTraLopKhongCoGioiTinh(lop, false)) kq.Add(lop);
            return kq;
        }

        public List<string> TimLopKhongCoSinhVienNam()
        {
            List<string> kq = new List<string>();
            foreach (var lop in LayDanhSachLop())
                if (KiemTraLopKhongCoGioiTinh(lop, true)) kq.Add(lop);
            return kq;
        }

        // Đếm số lượng sinh viên theo lớp
        public Dictionary<string, int> DemSoLuongSinhVienTheoLop()
        {
            Dictionary<string, int> kq = new Dictionary<string, int>();

            foreach (var lop in LayDanhSachLop())
                kq.Add(lop, DanhSachSVCua1Lop(lop).ds.Count);

            return kq;
        }

        // Xóa tất cả sinh viên của một lớp nào đó
        public void XoaTatCaSinhVienCuaLop(string tenLop)
        {
            ds.RemoveAll(sv => sv.Lop == tenLop);
        }

        // Xep loai sinh vien dua tren diem trung binh
        


        public Dictionary<string, string> XepLoaiTatCaSinhVien()
        {
            Dictionary<string, string> kq = new Dictionary<string, string>();

            foreach (var sv in ds)
                kq.Add(sv.maSV, sv.XepLoai());

            return kq;
        }
    }
}
