using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BoxingUnBoxing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for this content");
            object value = Console.ReadLine();
            Console.WriteLine("The interal data type stored is " + value.GetType().ToString());
            Console.WriteLine("The upper case of this data is " + value.ToString().ToUpper());
            Console.Read();
        }
    }
}
