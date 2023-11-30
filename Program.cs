using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = new Source { ID = 1, Name = "John Doe", BirthDate = new DateTime(1985, 5, 15) };
            var destination = new Destination { City = "New York" };

            Mapper.MapProperties(source, destination);

            Console.WriteLine($"ID: {destination.ID}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"BirthDate: {destination.BirthDate}");
            Console.WriteLine($"City: {destination.City}");
            Console.ReadKey();
        }
    }
}
