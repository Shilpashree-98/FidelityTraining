using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a function called "sumOfPrimes", that takes two integers as input and returns the sum of all the prime numbers between the same.

//public int sumOfPrimes(int from, int to)
//{
// do stuff here
// return 0;
//}

//Write a  program to call the above function multiple times with different values.
namespace Assignment1.Day02
{
    class Day2Assignment1
    {
        static bool checkPrime(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;

            }
            for (int i = 2; i * i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int sumOfPrimes(int from, int to)
        {
            int sum = 0;
            for (int i = to; i >= from; i--)
            {
                bool isPrime = checkPrime(i);
                if (isPrime)
                {
                    sum = sum + i;
                }

            }
            return sum;

        }

        public static void Main()
        {
            Console.WriteLine("Enter the starting bound");
            int rangefrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Upper bound");
            int rangeto = Convert.ToInt32(Console.ReadLine());

           
            Console.Write(sumOfPrimes(rangefrom, rangeto));
            Console.Read();

        }
    }
}