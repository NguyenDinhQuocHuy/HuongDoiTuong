using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD3_Vehicles
{
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Xe hoi dang di chuyen...");
        }

        public override void Stop()
        {
            Console.WriteLine("Xe hoi dang dung...");
        }
    }
}
