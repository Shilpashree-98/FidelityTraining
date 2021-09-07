using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create an array of strings with size based on the size of the team and take  inputs from the user to store the names. 
//Display the names using foreach loop.

namespace Assignment1.Day02
{
    class Day2Assignment4
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];
            Console.WriteLine("Enter the Names");

            for (int i=0;i<names.Length;i++)
            {
                
                names[i] = Console.ReadLine();

            }
            Console.WriteLine("-----Teams----");
            foreach (string name in names)
            {
                
                Console.Write(name+"\n");
            }


            Console.Read();
        }
    }
}
