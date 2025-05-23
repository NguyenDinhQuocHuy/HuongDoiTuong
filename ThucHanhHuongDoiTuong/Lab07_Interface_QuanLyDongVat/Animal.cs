using Lab07_Interface_QuanLyDongVat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Interface_QuanLyDongVat
{
    class Animal : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public void Speak()
        {
            Console.WriteLine("...");
        }

        public override string ToString()
        {
            return string.Format($"Name: {Name}, Age: {Age}");
        }
    }
}

