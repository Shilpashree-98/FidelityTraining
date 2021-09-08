using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a program to create the instance of the Employee and set the values using User inputs. Read the data after setting the Employee details.
//class Employee1
//{
//public int EmpId { get; set; }
//public string EmpName { get; set; }
//public string EmpAddress { get; set; }
//public DateTime EmpDob { get; set; }




//}
//class Day3Assignment2
//{
//static void Main(string[] args)
//{
//Employee1 emp = new Employee1();
//Console.WriteLine("Enter the Employee ID");
//int eid = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Employee Name");
//string name = Console.ReadLine();
//Console.WriteLine("Enter the Employee Address");
//string address = Console.ReadLine();
// Console.WriteLine("Enter the Employee Date of Birth");
//DateTime date = Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine("Employee Details:\n");
//Console.WriteLine($"EmpID: {eid} \n EmpName:{name}\nEmpAddress: {address}\nEmpDob:{date.ToShortDateString()}");
//Console.Read();
// }
namespace Assignment1.Day03
{
    class Employee1
    {
        private int empid;
        public int EmpId { get { return empid; } set { empid = value; } }
        private string empname;
        public string EmpName { get { return empname; } set { empname = value; } }
        private string empaddress;
        public string EmpAddress { get { return empaddress; } set { empaddress = value; } }
        private DateTime date;
        public DateTime EmpDob { get { return date; } set { date = value; } }


    }
    class Day3Assignment2
    {
        static void Main(string[] args)
        {
              
            Employee1 emp = new Employee1();
            Console.WriteLine("Enter the Employee ID");
            int eid = Convert.ToInt32(Console.ReadLine());
            emp.EmpId = eid;
            
            Console.WriteLine("Enter the Employee Name");
            string name = Console.ReadLine();
            emp.EmpName = name;
           
            Console.WriteLine("Enter the Employee Address");
            string address = Console.ReadLine();
            emp.EmpAddress = address;
            
            Console.WriteLine("Enter the Employee Date of Birth");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            emp.EmpDob = date;
            
            Console.WriteLine("Employee Details:\n");
            Console.WriteLine($"EmpID: {eid} \n EmpName:{name}\nEmpAddress: {address}\nEmpDob:{date.ToShortDateString()}");
            Console.Read();
        }
    }
}
