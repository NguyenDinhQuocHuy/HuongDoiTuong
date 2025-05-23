using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD2_Person
{
    public class Student : Person
    {
        public string School { get; set; }
        public override void Speak()
        {
            Console.WriteLine($"My name's {Name}, {Age} years old, I'm a student, studying at {School} school");
        }

        public void Study()
        {
            Console.WriteLine("Studying...");
        }
    }
}
