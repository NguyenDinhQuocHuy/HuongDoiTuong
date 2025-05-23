using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_QuanLyPhuongTien_DaKeThua
{
    interface ICar
    {
        int SoChoNgoi { get; set; }
        void DongCua()
        {
            Console.WriteLine("Dong cua...");
        }

        void MoCua()
        {
            Console.WriteLine("Mo cua...");
        }
    }
}
