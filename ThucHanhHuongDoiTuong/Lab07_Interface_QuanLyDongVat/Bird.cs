using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Interface_QuanLyDongVat
{
    class Bird : Animal, IFlyable
    {       
        public Bird(string name, int age )
        {
            Age = age;
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine("Chirp! Tweet!");
        }

        public void Fly()
        {
            Console.WriteLine("The bird is flying...");
        }
    }
}
