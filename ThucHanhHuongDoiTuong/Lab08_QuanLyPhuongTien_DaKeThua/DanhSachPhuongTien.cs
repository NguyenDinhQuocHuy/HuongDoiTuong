using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab08_QuanLyPhuongTien_DaKeThua
{
    public class DanhSachPhuongTien
    {
        List<IVehicle> collection;

        public DanhSachPhuongTien()
        {
            collection = new List<IVehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            collection.Add(vehicle);
        }

        public void Show()
        {
            foreach (var vehicle in collection)
            {
                Console.WriteLine(vehicle);
            }
        }

        public void AddVehicleFromLine(string line)
        {
            Vehicle v = null;
            var s = line.Split(",");
            string ten = s[1];
            int tocDo = int.Parse(s[2]);
            string type = s[0];

            if (type == "Car" && s.Length == 4)
            {
                int soChoNgoi = int.Parse(s[3]);
                v = new Car(ten, tocDo, soChoNgoi);
            }
            else if (type == "Motorcycle")
                v = new Motorcycle(ten, tocDo);

            if (v != null)
                AddVehicle(v);          
        }

        public void ReadFromFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            var line = "";
            while ((line = sr.ReadLine()) != null)
                AddVehicleFromLine(line);
            sr.Close();
        }

        // Case 6: Đếm số lượng theo loại kết hợp 
        // Phương tiện là Car, Motorcycle
        public int CountVehicleIsCar()
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle is Car)
                    count++;
            return count;
        }

        public int CountVehicleIsMotorcycle()
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle is Motorcycle)
                    count++;
            return count;
        }

        // Phương tiện là Car hoặc Motocycle
        public int CountVehicleIsCarOrMotorcycle()
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle is Car || vehicle is Motorcycle)
                    count++;
            return count;
        }

        // Loại điêu kiện:
        // Đếm phương tiện theo tên:
        public int CountVehicle_Name(string name)
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle.Ten == name)
                    count++;
            return count;
        }

        // Theo số chỗ ngồi
        public int CountVehicle_Seat(int number)
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle is Car car && car.SoChoNgoi == number)
                    count++;
            return count;
        }

        // Theo tốc độ
        public int CountVehicle_Speed(int speed)
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle.TocDo == speed)
                    count++;
            return count;
        }

        // Theo tên, số chỗ ngồi
        public int CountVehicle_NameSeat(string name, int number)
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle is Car car)
                    if (vehicle.Ten == name && car.SoChoNgoi == number)
                        count++;
            return count;
        }

        // Theo tên, tốc độ
        public int CountVehicle_NameSpeed(string name, int speed)
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle.Ten == name && vehicle.TocDo == speed)
                    count++;
            return count;
        }

        // Theo tên, chỗ ngồi, tốc độ
        public int CountVehicle_NameSeatSpeed(string name,  int number, int speed)
        {
            int count = 0;
            foreach (var vehicle in collection)
                if (vehicle is Car car)
                    if (vehicle.Ten == name && vehicle.TocDo == speed && car.SoChoNgoi == number)
                        count++;
            return count;
        }

        // Loại so sánh
        // Tìm tốc độ lớn nhất
        public int FindMaxSpeed()
        {
            int maxSpeed = collection[1].TocDo;
            foreach (var vehicle in collection)
                if (vehicle.TocDo > maxSpeed)
                    maxSpeed = vehicle.TocDo;
            return maxSpeed;
        }

        // Tìm tốc độ nhỏ nhất
        public int FindMinSpeed()
        {
            int minSpeed = collection[1].TocDo;
            foreach (var vehicle in collection)
                if (vehicle.TocDo < minSpeed)
                    minSpeed = vehicle.TocDo;
            return minSpeed;
        }

        // Đếm phương tiện có tốc độ lớn nhất
        public int CountMaxSpeed()
        {
            int count = 0, maxSpeed = FindMaxSpeed();
            foreach (var vehicle in collection)
                if (vehicle.TocDo == maxSpeed)
                    count++;
            return count;
        }

        // Đếm phương tiện có tốc độ nhỏ nhất
        public int CountMinSpeed()
        {
            int count = 0, minSpeed = FindMinSpeed();
            foreach (var vehicle in collection)
                if (vehicle.TocDo == minSpeed)
                    count++;
            return count;
        }
        
        // Tìm số chỗ ngồi max
        public int FindMaxSeats()
        {
            int maxSeats = 0;
            foreach (var vehicle in collection)
                if (vehicle is Car car)
                    if (car.SoChoNgoi > maxSeats)
                        maxSeats = car.SoChoNgoi;
            return maxSeats;
        }

        // Tìm số chỗ ngồi min
        public int FindMinSeats()
        {
            int minSeats = 100;
            foreach (var vehicle in collection)
                if (vehicle is Car car)
                    if (car.SoChoNgoi < minSeats)
                        minSeats = car.SoChoNgoi;
            return minSeats;
        }

        // Đếm phương tiện có chỗ ngồi max
        public int CountVehicle_MaxSeats()
        {
            int count = 0, maxSeat = FindMaxSeats();
            foreach (var vehicle in collection)
                if (vehicle is Car car)
                    if (car.SoChoNgoi == maxSeat)
                        count++;
            return count;
        }

        // Đếm phương tiện có chỗ ngồi min
        public int CountVehicle_MinSeats()
        {
            int count = 0, minSeat = FindMinSeats();
            foreach (var vehicle in collection)
                if (vehicle is Car car)
                    if (car.SoChoNgoi == minSeat)
                        count++;
            return count;
        }

        // Chuỗi là chiều dài ngắn nhất, dài nhất
        // Tìm chiều dài chuỗi dài nhất
        public int FindLongestStringLength()
        {
            int longest = collection[0].Ten.Length;
            foreach (var vehicle in collection)
            {
                int i = vehicle.Ten.Length;
                if (i > longest)
                    longest = i;
            }
            return longest;
        }

        // Tìm chiều dài chuỗi ngắn nhất
        public int FindshortestStringLength()
        {
            int shortest = collection[0].Ten.Length;
            foreach (var vehicle in collection)
            {
                int i = vehicle.Ten.Length;
                if (i < shortest)
                    shortest = i;
            }
            return shortest;
        }

        // Đếm phương tiện có tên dài nhất


        // Đếm phương tiện có tên ngắn nhất

    }
}
