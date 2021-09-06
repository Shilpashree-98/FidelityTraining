using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class InputDisplay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name please");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Age please");
            string age = Console.ReadLine();

            Console.WriteLine("Enter the Qualification");
            string qualification = Console.ReadLine();

            Console.WriteLine("Thanks for the info. The Details here are as mentioned:\nThe Name entered is " + name);
            Console.WriteLine("The Age is " + age);
            Console.WriteLine("The Qualification of this User is " + qualification);
            Console.Read();
        }
    }
}
