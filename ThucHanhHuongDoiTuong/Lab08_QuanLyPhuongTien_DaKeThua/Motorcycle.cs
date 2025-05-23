using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_QuanLyPhuongTien_DaKeThua
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        public Motorcycle(string ten, int tocDo) : base (ten, tocDo) { }
        int banDau;
        int lucSau;
        public void GiamToc()
        {
            banDau = this.TocDo;
            lucSau = (this.TocDo -= 5);
            Console.WriteLine($"Toc so ban dau: {banDau}, sau khi giam: {lucSau}");
        }
        public void TangToc()
        {
            banDau = this.TocDo;
            lucSau = (this.TocDo += 5);
            Console.WriteLine($"Toc do ban dau: {banDau}, sau khi tang: {lucSau}");
        }
    }
}
