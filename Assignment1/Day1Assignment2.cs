using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to ask the user for a number and display its multiplication table, using a "while" statement. The result must be like this: 5 x 1 = 5 5 x 2 = 10 5 x 3 = 15
namespace Assignment1
{
    class Day1Assignment2
    {
        public static void Main()
        {
      
            Console.WriteLine("Enter the number");
            int num=(int)Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(num + "*" + i + "=" + i * num);
                i++;
             }
            Console.ReadLine();


        }

    }
}
