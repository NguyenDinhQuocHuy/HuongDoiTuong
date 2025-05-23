using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD4_Shape
{
    public class Square : Rectangle
    {
        // Hinh vuong thua ke tu hinh chu nhat, vi hinh vuong cung la hcn nhung cac canh deu bang nhau
        public Square(double size) : base (size, size) { }
        public override void Draw()
        {
            Console.WriteLine("Ve hinh vuong...");
        }
    }
}
