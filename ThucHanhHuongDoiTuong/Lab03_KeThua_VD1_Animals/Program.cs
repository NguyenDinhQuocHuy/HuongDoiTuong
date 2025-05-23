using Lab03_KeThua_VD1_Animals;

class Program
{
    static void Main()
    {
        ListAnimal list = new ListAnimal();
        list.LoadFromFile("data.txt");
        list.Xuat();
    }
}


