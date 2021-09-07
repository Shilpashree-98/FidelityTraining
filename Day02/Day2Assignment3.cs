using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a  program to print the following pattern:

//**
//The number of rows should be based on the value of a variable "num", and the number of stars in a row is based on the row number itself.

namespace Assignment1.Day02
{
    class Day2Assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Rows");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.Write("*");
            }
            Console.Read();
        }

    }
}
