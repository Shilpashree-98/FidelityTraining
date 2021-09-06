using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DateTimeConversion
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Date of Birth as dd/MM/yyyy");
			string dob = Console.ReadLine();

			DateTime dt = DateTime.Parse(dob);//Function used to Convert string to a valid Date
			int age = DateTime.Now.Year - dt.Year;//Difference in Years of 2 given Dates
			Console.WriteLine("UR age is currently " + age + " Years");
			Console.Read();

		}
	}
	
}
