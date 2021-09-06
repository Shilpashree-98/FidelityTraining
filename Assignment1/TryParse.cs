using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TryParse
    {
        static void Main(String[] args)
        {
            int age;
        RETRY:
            Console.WriteLine("Enter the Age");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"U R supposed to enter a whole number ranging from {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            Console.WriteLine($"The age is {age}");//New in C# 5.0
            Console.Read();
        }
    }
}

