using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD2_Person
{
    class People
    {
        public List<Person> collection { get; private set; } = new List<Person>();

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Can't find the data!");
                return;
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(",");
                    if (parts.Length < 3) continue; // Bo qua dong loi

                    string type = parts[0].Trim();
                    string name = parts[1].Trim();
                    int age = int.Parse(parts[2].Trim());

                    if (type == "Person")
                        collection.Add(new Person { Name = name, Age = age });
                    else if (type == "Student" && parts.Length == 4)
                    {
                        string school = parts[3].Trim();
                        collection.Add(new Student { Name = name, Age = age, School = school });
                    }
                    else if (type == "Teacher" && parts.Length == 4)
                    {
                        string subject = parts[3].Trim();
                        collection.Add(new Teacher { Name = name, Age = age, Subject = subject });
                    }
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("People in the system: ");
            foreach (var person in collection)
                person.Speak();
        }
    }
}
