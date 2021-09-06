using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a function called "sortThreeNumbers", which takes 3 distinct integers and prints them in ascending order. public void sortThreeNumbers(int a, int b, int c) { // do stuff here } For example,

//sortThreeNumbers(2, 10, 1); // prints 1, 2, 10
//sortThreeNumbers(20, 10, 1); // prints 1, 10, 20
//sortThreeNumbers(2, 10, 100); // prints 2, 10, 100 and so on.
//Write a program to call the above function multiple times with different values.
   
namespace Assignment1
{
    class Day1Assignment6
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            SortThreeNumbers(n1, n2, n3);

        }
        public static void  SortThreeNumbers(int a,int b,int c)
        {
            int x = 0, y = 0, z = 0;
            if(a>b)
            {
                y = a;
                z = b;

            }
            else
            {
                y = b;
                z = a;

            }
            if(y>c)
            {
                x = y;
                if (z > c)
                {
                    y = z;
                    z = c;

                }
                else
                {
                    y = c;

                }

            }
            else
            {
                x = c;

            }
            Console.WriteLine(" " + x + " " + y + " " + z);
            Console.Read();


        }
       

    }
}
