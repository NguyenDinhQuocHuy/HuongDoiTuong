using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD1_Animals
{
    class ListAnimal
    {
        List<Animal> animals;

        public ListAnimal()
        {
            animals = new List<Animal>();
        }
        
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void Xuat()
        {
            foreach (var animal in animals)
                Console.WriteLine(animal.ToString());
        }

        public void LoadFromFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            Animal a;
            while ((line = sr.ReadLine()) != null)
            {
                var s = line.Split(",");
                var name = s[1];
                var age = Convert.ToInt32(s[2]);

                if (s[0] == "Dog")
                    a = new Dog(name, age, s[3].ToString());
                else if (s[0] == "Cat")
                    a = new Cat(name, age, s[3].ToString());
                else
                    a = new Lion(name, age, s[3].ToString());
                AddAnimal(a);
            }
            sr.Close();
        }
    }
}
