using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab07_Interface_QuanLyDongVat
{
    class ListAnimal
    {
        public List<Animal> collection = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            collection.Add(animal);
        }

        public void Show() // Xuất danh sách animal
        {
            foreach (var animal in collection)
                Console.WriteLine(animal);
        }

        public void LoadFromFile(string filePath)
        {
            // Type,Name,Age
            StreamReader sr = new StreamReader(filePath);
            string line = "";           
            while ((line = sr.ReadLine()) != null)
            {
                AddAnimalFromLine(line);
            }
            sr.Close();
        }

        // Hàm thêm một animal từ một dòng
        public void AddAnimalFromLine(string line)
        {
            Animal a = null;
            var s = line.Split(",");
            string name = s[1];
            int age = int.Parse(s[2]);

            if (s[0] == "Lion")
                a = new Lion(name, age);
            else if (s[0] == "Bat")
                a = new Bat(name, age);
            else if (s[0] == "Bird")
                a = new Bird(name, age);

            // Nếu a là một animal
            if (a != null)
                AddAnimal(a);
        }


        // Đếm số lượng Bat, Lion, Bird
        public int CountAnimalIsBat()
        {
            int count = 0;
            foreach (var animal in collection)
                if (animal is Bat)
                    count++;
            return count;
        }

        public int CountAnimalIsBird()
        {
            int count = 0;
            foreach (var animal in collection)
                if (animal is Bird)
                    count++;
            return count;
        }

        public int CountAnimalIsLion()
        {
            int count = 0;
            foreach (var animal in collection)
                if (animal is Lion)
                    count++;
            return count;
        }
        
        public int CountFlyableAnimals()
        {
            int count = 0;
            foreach (var animal in collection)
                if (animal is IFlyable)
                    count++;
            return count;
        }

        public int CountFlightlessAnimals()
        {
            int count = 0;
            foreach (var animal in collection)
                if (animal is not IFlyable)
                    count++;
            return count;
        }
      
        public int CountAnimalFlyable_NameAge(string name, int age)
        {
            int count = 0;
            foreach (var animal in collection)
                if ((animal.Name == name) && (animal is IFlyable) && (animal.Age == age))
                    count++;
            return count;
        }

        public int CountAnimalFlightless_NameAge(string name, int age)
        {
            int count = 0;
            foreach (var animal in collection)
                if ((animal.Name == name) && (animal is not IFlyable) && (animal.Age == age))
                    count++;
            return count;
        }

        // Tìm động vật có số lượng nhiều nhất, ít nhất, Đếm số lượng từng loài, sau đó xuất ra tên của loài có số lượng lớn nhất
        public void FindTheMostAnimals()
        {
            // amount: Số lượng, kindList: Danh sách loài, index: Chỉ số
            var kindList = new List<string>(); // Tạo 1 mảng danh sách các loài ["Bat", "Lion", "Bird]
            var amount = new List<int>();      // Danh sách amount tương ứng với kindList
            foreach (var a in collection)
            {
                string kind = a.GetType().Name; // Lấy ra tên loài (class) : a = new Lion("Leo", 5) thì kind == "Lion
                int index = kindList.IndexOf(kind); // Kiểm tra xem loại kind có xuất hiện trong lindList không, có thì trả về >=0, không thì <0
                if (index >= 0) amount[index]++;
                else 
                { 
                    kindList.Add(kind); 
                    amount.Add(1); 
                }               
            }
            int max = amount.Max();
            int indexMax = amount.IndexOf(max);
            Console.WriteLine($"Loai nhieu nhat la {kindList[indexMax]} ({max} con)");
        }

        // Tìm tất cả động vật thuộc loài Bat
        public void FindAnimalIsBat()
        {
            foreach (var animal in collection)
                if (animal.GetType().Name == "Bat")
                    Console.WriteLine(animal);
        }

        public void FindAnimalIsLion()
        {
            foreach (var animal in collection)
                if (animal.GetType().Name == "Lion")
                    Console.WriteLine(animal);
        }

        public void FindAnimalIsBird()
        {
            foreach (var animal in collection)
                if (animal.GetType().Name == "Bird")
                    Console.WriteLine(animal);
        }

        // Tìm tất cả động vật có tên ngắn nhất

    }
}




