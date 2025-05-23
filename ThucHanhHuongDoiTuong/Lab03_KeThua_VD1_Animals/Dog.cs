using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD1_Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; } // Giong loai

        public Dog(string name, int age ,string breed) : base(name, age)
        {
            this.Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine("Gau gau !!!");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"{0, -10}", this.Breed);
        }
    }
}
