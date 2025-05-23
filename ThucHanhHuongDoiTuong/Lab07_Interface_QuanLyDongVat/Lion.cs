using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Interface_QuanLyDongVat
{
    class Lion : Animal
    {       
        public Lion(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine("Roar!");
        }
    }
}
