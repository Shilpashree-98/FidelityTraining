using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In mathematics, the Fibonacci numbers are the numbers in the following integer sequence, characterized by the fact that every number after the first two numbers is the sum of the two preceding ones:

//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...

//Write a function called "fibonacci", that takes index as paramter and returns the fibonacci number at that index.

namespace Assignment1.Day02
{
    class Day2Assignment2
    {
        public static int Fib(int n)
        {
            if(n <=1)
            {
                  return n;
            }
            else
            {
               return Fib(n -1)+Fib(n-2);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.Write(Fib(n));
            Console.Read();
           
        }

    }
}


