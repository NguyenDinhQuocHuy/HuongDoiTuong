using System;
using Lab07_Interface_QuanLyDongVat;

class Program
{ 
    static void Main()
    {
        ListAnimal ds = new ListAnimal();
        while (true)
        {
            Console.Clear();
            XuatMenu();
            Console.Write("Nhap 1 so de chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    ds.LoadFromFile("data.txt");
                    Console.WriteLine("Da doc file xong !");
                    break;

                case 2:
                    Console.WriteLine("Nhap vao mot string de tao mot doi tuong animal (Loai,Ten,Tuoi) :");
                    string line = Console.ReadLine();
                    ds.AddAnimalFromLine(line);
                    break;

                case 3:
                    Console.WriteLine("Danh sach animal");
                    ds.Show();
                    break;

                case 4:
                    int s1 = ds.CountAnimalIsBat();
                    int s2 = ds.CountAnimalIsLion();
                    int s3 = ds.CountAnimalIsBird();                  
                    Console.Write("Dem so luong Bat(1), Lion(2), Bird (3), All(0) , nhap mot so: ");
                    int so = int.Parse(Console.ReadLine());
                    if (so == 0)
                    {
                        Console.WriteLine("So luong Bat: " + s1);
                        Console.WriteLine("So luong Bat: " + s2);
                        Console.WriteLine("So luong Bat: " + s3);
                    }
                    else if (so == 1) Console.WriteLine("So luong Bat: " + s1);
                    else if (so == 2) Console.WriteLine("So luong Lion: " + s2);
                    else if (so == 3) Console.WriteLine("So luong Bird: " + s3);
                    break;

                case 5:
                    s1 = ds.CountFlyableAnimals();
                    s2 = ds.CountFlightlessAnimals();
                    Console.Write("Dem so luong biet bay(1), không biet bay(2), ca hai(0) , nhap mot so:");
                    so = int.Parse(Console.ReadLine());
                    if (so == 0)
                    {
                        Console.WriteLine("So luong dong vat biet bay: " + s1);
                        Console.WriteLine("So luong dong vat khong biet bay: " + s2);
                    }
                    else if (so == 1) Console.WriteLine("So long dong vat biet bay: " + s1);
                    else if (so == 2) Console.WriteLine("So luong dong vat khong biet bay: " + s2);
                    break;

                case 6:
                    
                    Console.Write("Dem so luong biet bay(1), khong biet bay(2) theo ten tuoi, nhap mot so:");
                    so = int.Parse(Console.ReadLine());
                    Console.Write("Nhap ten: ");
                    string name = Console.ReadLine();
                    Console.Write("Nhap tuoi: ");
                    int age = int.Parse(Console.ReadLine()); 

                    s1 = ds.CountAnimalFlyable_NameAge(name, age);
                    s2 = ds.CountAnimalFlightless_NameAge(name, age);

                    if (so == 1) Console.WriteLine($"So luong biet bay theo ten {name}, tuoi {age} la: " + s1);
                    else if (so == 2) Console.WriteLine($"So luong khong biet bay theo ten {name}, tuoi {age} la: " + s2);
                    break;

                case 7:
                    ds.FindTheMostAnimals();
                    break;

                case 8:
                    Console.WriteLine("Dong vat thuoc loai Bat: ");
                    ds.FindAnimalIsBat();
                    Console.WriteLine("Dong vat thuoc loai Lion: ");
                    ds.FindAnimalIsLion();
                    Console.WriteLine("Dong vat thuoc loai Bird: ");
                    ds.FindAnimalIsBird();

                    break;

                case 9:

                    break;

                case 10:

                    break;



                default:
                    Console.WriteLine("Thoat chuong trinh !");
                    return;
            }

            Console.WriteLine("Nhan 1 phim bat ky de tiep tuc !");
            Console.ReadKey();
        }
    }

    static void XuatMenu()
    {
        Console.WriteLine("========== CHUC NANG ==========");
        Console.WriteLine("01. Nhap tu file");
        Console.WriteLine("02. Them mot IAnimal vao danh sach");
        Console.WriteLine("03. Viet phuong thuc ToString()");
        Console.WriteLine("04. Dem so luong dong vat la Bat, Lion, Bird");
        Console.WriteLine("05. Dem so luong dong vat biet bay, khong biet bay");
        Console.WriteLine("06. Dem so luong dong vat biet bay, khong biet bay theo ten tuoi");
        Console.WriteLine("07. Tim dong vat co so luong nhieu nhat, it nhat");
        Console.WriteLine("08. Tim tat ca dong vat thuoc loai Bat, Lion, Bird");
        Console.WriteLine("09. Tim tat ca dong vat co ten ngan nhat, dai nhat");
        Console.WriteLine("10. Tim tat ca dong vat co tuoi lon nhat, nho nhat theo loai");
        Console.WriteLine();       
    }
}

