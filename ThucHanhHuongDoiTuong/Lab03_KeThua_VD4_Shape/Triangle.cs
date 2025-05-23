using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD4_Shape
{
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            if (IsEquilateral()) // La tam giac deu
            {
                return (Math.Sqrt(3) / 4) * a * a;
            }
            else if (IsRightTriangle()) // La tam giac vuong
            {
                // Tìm 2 cạnh góc vuông
                double[] sides = new double[] { a, b, c };
                Array.Sort(sides); // sides[2] là cạnh huyền
                return 0.5 * sides[0] * sides[1];
            }
            else if (IsIsosceles()) // La tam giac can
            {
                // Tính chiều cao rồi áp dụng (1/2 * base * height)
                double baseSide, equalSide;
                if (a == b) { equalSide = a; baseSide = c; }
                else if (a == c) { equalSide = a; baseSide = b; }
                else { equalSide = b; baseSide = a; }

                double height = Math.Sqrt(equalSide * equalSide - (baseSide * baseSide) / 4);
                return 0.5 * baseSide * height;
            }
            else
            {
                // Tam giác thường → dùng Heron
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle...");
            if (IsEquilateral())
                Console.WriteLine("This is an equilateral triangle.");
            else if (IsIsosceles())
            {
                if (IsRightTriangle())
                    Console.WriteLine("This is an isosceles right triangle.");
                else
                    Console.WriteLine("This is an isosceles triangle.");
            }
            else if (IsRightTriangle())
                Console.WriteLine("This is a right triangle.");
            else
                Console.WriteLine("This is a scalene triangle.");
        }

        private bool IsEquilateral() // Tam giac deu
        {
            return a == b && b == c;
        }

        private bool IsIsosceles() // Tam giac can
        {
            return a == b || b == c || a == c;
        }

        private bool IsRightTriangle() // Tam giac vuong
        {
            double aa = a * a, bb = b * b, cc = c * c;
            return Math.Abs(aa + bb - cc) < 1e-6 ||
                   Math.Abs(aa + cc - bb) < 1e-6 ||
                   Math.Abs(bb + cc - aa) < 1e-6;
        }
    }
}
