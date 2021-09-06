using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a C# program to ask the user for 10 real numbers and display the average of the positive ones and the average of the negative ones.
namespace Assignment1
{
    class Day1Assignment3
    {
        public static void Main(String[] args)
        {
            int i, n, sumnegative=0, sumpositive=0,posInc=0,negInc=0;
            double avgpositive=0, avgnegative=0;
            Console.WriteLine("Enter the 10 real Numbrrs");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number={0}:", i);
                n = Convert.ToInt32(Console.ReadLine());
                
                if (n > 0)
                {
                    sumpositive +=n;
                    posInc = posInc + 1;
                }
                else
                {
                    sumnegative += n;
                    negInc = negInc + 1;
                }


            }
            avgnegative = sumnegative / negInc;
            avgpositive = sumpositive / posInc;
            Console.Write("The Sum of the Positive Number is:{0}\n", sumpositive);
            Console.Write("The Avg of the Positive Number is:{0}\n", avgpositive);
            Console.Write("The Sum of the Negative Number is:{0}\n", sumnegative);
            Console.Write("The Avg of the Negative Number is:{0}\n", avgnegative);
            Console.Read();
        }
    }
}