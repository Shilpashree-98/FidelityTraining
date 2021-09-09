using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a Calc Program that will take inputs from the user and displays the data based on the operator selected by the User...
namespace Assignment1.Day04
{
    class Day4Assignment3
    {
        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        public static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public static int Division(int num1, int num2)
        {
            
                int result = num1 / num2;
                return result;
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\nEnter your Choice???");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st Value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case 1:
                    {
                        result = Addition(num1, num2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(num1, num2);
                        break;
                    }
                case 4:
                    {
                        if (num2 != 0)
                        {
                            result = Division(num1, num2);

                        }
                        else 
                        {
                            Console.WriteLine("Divide by zero");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }

    }
}
