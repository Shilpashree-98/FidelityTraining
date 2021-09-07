using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day02
{
   


    //Main method is static? This method is called by the Runtime without an object getting created. C# does not support global variables and global functions. All are supposed to be the part of the class. They are all singleton. They are also called as Shared data.

    static class MathClass
    {
        public static double AddFunc(double v1, double v2) => v1 + v2;
        public static double SubFunc(double v1, double v2) => v1 - v2;
        public static double MulFunc(double v1, double v2) => v1 * v2;
        public static double DivFunc(double v1, double v2) => v1 / v2;
        public static double Sqrt(double v1) => Math.Sqrt(v1);
        public static double Sqr(double v1) => MulFunc(v1, v1);
    }

    class Methods
    {

        static void Main(string[] args)
        {
            var v1 = MyConsole.GetDouble("Enter the First value");
            var v2 = MyConsole.GetDouble("Enter the Second value");
            double addedValue = MathClass.AddFunc(v1, v2);
            Console.WriteLine($"The Added value: {addedValue}");

            //var is a convinient way of refering local variables. 
            var subtractedValue = MathClass.SubFunc(345.67, 56.66);
            Console.WriteLine($"The Subtracted value: {subtractedValue}");
            Console.Read();

        }
    }
}