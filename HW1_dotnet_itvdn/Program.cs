using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_dotnet_itvdn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сторона а:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сторона b:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");

            Console.ReadKey();
        }
    }
}
