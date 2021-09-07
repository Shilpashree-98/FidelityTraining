using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day02
{
    class ObjectsDemo
    {
        static void Main(string[] args)
        {
            //Type Initializer in C# 4.0
            Employee emp = new Employee { EmpID = 613098, EmpAddress = "Karkala", EmpName = "Shilpashree" };//creating object in C#....

            Console.WriteLine(emp.EmpID);//get
            Console.WriteLine(emp.EmpName);//get
            Console.WriteLine(emp.EmpAddress);//get
            Console.Read();

        }
    }
}
