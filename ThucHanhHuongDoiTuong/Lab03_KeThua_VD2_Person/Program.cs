using Lab03_KeThua_VD2_Person;

class Program
{
    static void Main()
    {
        People people = new People();
        people.LoadFromFile("data.txt");
        people.PrintAll();
    }
}