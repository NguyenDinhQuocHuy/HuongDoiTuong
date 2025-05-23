using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD1_Animals
{
    public class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string color) : base(name, age)
        {
            this.Color = color;
        }

        public override void Speak()
        {
            Console.WriteLine("Mew Mew !!!");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"{0,-10}", this.Color);
        }
    }
}
