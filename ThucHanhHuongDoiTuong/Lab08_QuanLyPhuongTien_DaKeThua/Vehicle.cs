using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_QuanLyPhuongTien_DaKeThua
{
    public class Vehicle : IVehicle
    {
        public string Ten { get; set; }
        public int TocDo { get; set; }

        public Vehicle(string ten, int tocDo)
        {
            Ten = ten;
            TocDo = tocDo;
        }
        public void Chay()
        {
            Console.WriteLine("Dang chay...");
        }
        public void Dung()
        {
            Console.WriteLine("Dung !");
        }

        public override string ToString()
        {
            return string.Format($"Ten: {Ten}, toc do: {TocDo}");
        }
    }
}
