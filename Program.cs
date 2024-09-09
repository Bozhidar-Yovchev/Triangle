using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a: "); // side a 
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b:  ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side c:  ");
            int c = int.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a,b,c);
            Console.WriteLine($"Perimeter of the triangle is {triangle.P()}");
            Console.WriteLine($"Area of the triagle is {triangle.S():f2}");
        }
    }
}
