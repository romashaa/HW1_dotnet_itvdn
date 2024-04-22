using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "12345";
            address.Country = "Україна";
            address.City = "Київ";
            address.Street = "Вулиця Шевченка";
            address.House = "1";
            address.Apartment = "5";

            Console.WriteLine("Індекс: " + address.Index);
            Console.WriteLine("Країна: " + address.Country);
            Console.WriteLine("Місто: " + address.City);
            Console.WriteLine("Вулиця: " + address.Street);
            Console.WriteLine("Будинок: " + address.House);
            Console.WriteLine("Квартира: " + address.Apartment);
            Console.ReadKey();
        }
    }
}
