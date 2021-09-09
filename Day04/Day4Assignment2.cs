using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Display the details by storing the data as variables and use string format to display them
namespace Assignment1.Day04
{
    class Day4Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your EmployeeID");
            var empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the Salary");
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Date of Birth as dd/MM/yyyy");
            DateTime dt = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Employee ID {0} name is {1} with salary of {2:C} and his DOB is {3}",empid, name, salary, dt.ToString("dd MMM yy"));
            Console.Read();

        }
    }
}
