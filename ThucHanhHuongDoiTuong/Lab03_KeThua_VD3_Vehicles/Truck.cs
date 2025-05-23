using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD3_Vehicles
{
    public class Truck : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Xe tai dang di chuyen...");
        }
        
        public override void Stop()
        {
            Console.WriteLine("Xe tai dang dung...");
        }
    }
}
