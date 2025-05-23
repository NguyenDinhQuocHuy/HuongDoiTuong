using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraDe1
{
    public class K : IA, IB
    {
        public K() { }
        public K(string c, string x, int y)
        {
            C = c;
            X = x;
            Y = y;
        }
        public string C { get; set; }
        public string X { get; set; }
        public int Y { get; set; }

        public string LayChieuDaiCuaC()
        {
            return $"{C.Length}";
        }

        public int TimSoKhoangTrangChuoiC()
        {
            int dem = 0;
            for (int i = 0; i < C.Length; i++)
                if (C[i] == ' ')
                    dem++;
            return dem;
        }
        public string ToString()
        {
            return string.Format(C.PadRight(10) + X.PadRight(10) + Y.ToString().PadRight(10));
        }
    }
}
