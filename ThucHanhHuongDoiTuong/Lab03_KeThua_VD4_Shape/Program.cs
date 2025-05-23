//Ví dụ 4: Quản lý các đối tượng hình học (tròn, tam giác …)

using Lab03_KeThua_VD4_Shape;

class Program
{
    static void Main()
    {
        Shape c = new Circle(5);
        Shape r = new Rectangle(4, 6);
        Shape s = new Square(3);

        Console.WriteLine($"Circle - Area: {c.Area()}, Perimeter: {c.Perimeter()}");
        c.Draw();

        Console.WriteLine($"Rectangle - Area: {r.Area()}, Perimeter: {r.Perimeter()}");
        r.Draw();

        Console.WriteLine($"Square - Area: {s.Area()}, Perimeter: {s.Perimeter()}");
        s.Draw();
    }
}