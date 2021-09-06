using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a C# program to convert from celsius degrees to Kelvin and Fahrenheit: it will ask the user for the amount of celsius degrees and using the following conversion tables:
//kelvin = celsius + 273
//fahrenheit = celsius x 18 / 10 + 32
namespace Assignment1
{
    class Day1Assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celcius");
            int cel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin={0}", cel + 273);
            Console.WriteLine("Fahrenheit={0}", cel * 18/10+32);
            Console.Read();


        }

    }
}
