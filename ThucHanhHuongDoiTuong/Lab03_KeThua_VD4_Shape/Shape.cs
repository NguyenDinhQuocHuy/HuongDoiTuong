using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD4_Shape
{
    public abstract class Shape
    {
        public abstract double Area(); // Dien tich
        public abstract double Perimeter(); // Chu vi

        public virtual void Draw()
        {
            Console.WriteLine("Ve hinh ...");
        }
    }
}
