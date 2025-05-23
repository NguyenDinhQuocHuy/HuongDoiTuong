using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_QuanLyPhuongTien_DaKeThua
{
    public class Car : Vehicle, ICar
    {
        public int SoChoNgoi { get; set; }

        public Car(string ten, int tocDo, int soChoNgoi) : base(ten, tocDo) // Ke thua Vehicle
        {           
            SoChoNgoi = soChoNgoi;
        }

        public void DongCua()
        {
            Console.WriteLine($"So cho ngoi ban dau: {this.SoChoNgoi}");
            var b = -1;
            if (this.SoChoNgoi >= 7)
                this.SoChoNgoi = 7;
            else
                this.SoChoNgoi = 0;
            Console.WriteLine($"So cho ngoi luc sau: {this.SoChoNgoi}");
        }

        public void MoCua()
        {
            Console.WriteLine("Mo cua o to...");
        }

        public override string ToString()
        {
            return base.ToString() + $", so cho ngoi: {SoChoNgoi}";
        }
    }
}
