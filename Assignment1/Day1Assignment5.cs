using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement the body for the following function: static boolean isPrimeNumber(int num) { return false; } The function should check and return true only if the number passed as argument is a prime number. Write a program to call the above function multiple times with different values.
namespace Assignment1
{
    class Day1
    {
        static bool isPrimeNumber(int num)
        {
            int count = 0;
            for(int i=1; i<=num; i++)
            {
                if (num % i == 0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                return true;
            }
            else
                return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the count ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<count; i++)
            {
                Console.WriteLine("Enter the Number");
                int num = Convert.ToInt32(Console.ReadLine());
                if(isPrimeNumber(num))
                    {
                    Console.WriteLine("Prime");
                }
                else if((isPrimeNumber(num))==false)
                {
                    Console.WriteLine("Not a Prime");
                }
                         
            }
            Console.ReadLine();

        }
    }
}
