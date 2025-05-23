using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD1_Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Thu dang keu...");
        }

        public override string ToString()
        {
            return string.Format($"Name: {0,-10}, Age: {1,-10}", Name, Age);
        }
    }
}
