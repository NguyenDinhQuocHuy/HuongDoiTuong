using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD1_Animals
{
    public class Lion : Animal
    {
        public string Subspecies { get; set; } // Phan loai theo khu vuc dia ly

        public Lion(string name, int age, string subs) : base (name, age)
        {
            this.Subspecies = subs;
        }
        public override void Speak()
        {
            Console.WriteLine("GAO OH GAO OH GAOOOOOOOOO");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"{0, -10}", this.Subspecies);
        }
    }
}
