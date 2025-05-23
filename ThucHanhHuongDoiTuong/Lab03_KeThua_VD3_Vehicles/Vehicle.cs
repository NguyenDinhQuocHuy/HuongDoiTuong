using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD3_Vehicles
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public virtual void Move()
        {
            Console.WriteLine(" ");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Dang dung...");
        }
    }
}
