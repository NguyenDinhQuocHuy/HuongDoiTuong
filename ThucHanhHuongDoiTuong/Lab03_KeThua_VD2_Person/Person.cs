using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD2_Person
{
    // Giao vien, sinh vien, nhan vien
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"I'm a person, my name's {Name}, {Age} years old");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
