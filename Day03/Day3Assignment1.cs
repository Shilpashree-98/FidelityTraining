using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class called Employee with properties called EmpID, EmpName, EmpAddress, EmpDOB. 

namespace Assignment1.Day03
{
    class Employee
    {
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String EmpAddress { get; set; }
        public DateTime EmpDob { get; set; }


    }
    class Day3Assignment1
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee { EmpId = 123, EmpName = "Shilpa", EmpDob = DateTime.Parse("10/12/1998"), EmpAddress = "Karkala" };
            Console.WriteLine(emp);
            Console.WriteLine($"EmpID: {emp.EmpId} \n EmpName:{emp.EmpName}\nEmpAddress: {emp.EmpAddress}\nEmpDob:{emp.EmpDob.ToShortDateString()}");
           Console.Read();
        }
    }
}

