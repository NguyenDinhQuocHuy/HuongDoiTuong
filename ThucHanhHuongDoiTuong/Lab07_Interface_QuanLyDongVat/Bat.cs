using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Interface_QuanLyDongVat
{
    class Bat : Animal, IFlyable
    {
        public Bat(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void Fly()
        {
            Console.WriteLine("The bat is flying...");
        }

        public void Speak()
        {
            Console.WriteLine("Screech! Screech!");
        }
    }
}
