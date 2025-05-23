using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD2_Person
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"My name's {Name}, {Age} years old, I'm a teacher, teaching {Subject}");
        }

        public void Teach()
        {
            Console.WriteLine("Teaching...");
        }
    }
}
