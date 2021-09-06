using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DataTypeConversion
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Age");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Age at which U wish to retire");
			int expectedRetirement = int.Parse(Console.ReadLine());
			Console.WriteLine("U R going to retire after " + (expectedRetirement - age) + " years");
			Console.Read();
		}
	}
}
