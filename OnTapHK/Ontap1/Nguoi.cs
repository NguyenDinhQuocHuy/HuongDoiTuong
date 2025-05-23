using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap1
{
    public class Nguoi
    {
        public string DiaChi { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }

        public Nguoi()
        {

        }
        public Nguoi(string diaChi, string ten, int tuoi)
        {
            this.DiaChi = diaChi;
            this.Ten = ten;
            this.Tuoi = tuoi;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine(Ten.PadRight(20) + DiaChi.PadRight(20) + Tuoi.ToString().PadRight(10));
        }
    }
}

