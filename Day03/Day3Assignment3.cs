using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create 5 employee objects and fill the data for it and observe how it behaves. 
namespace Assignment1.Day03
{
    class Employee3
    {
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String EmpAddress { get; set; }
        public DateTime EmpDob { get; set; }
    }

    class Day3Assignment3
    {
        //static void Main(string[] args)
        //{
        //    var emp = new Employee3[5];
        //    emp[0] = new Employee3 { EmpId = 1, EmpName = "Shilpa", EmpAddress = "Karkala", EmpDob = DateTime.Now.AddDays(-124) };
        //    emp[1] = new Employee3 { EmpId = 2, EmpName = "Aishu", EmpAddress = "Mysore", EmpDob = DateTime.Now.AddDays(-124) };
        //    emp[2] = new Employee3 { EmpId = 3, EmpName = "Anu", EmpAddress = "Udupi", EmpDob = DateTime.Now.AddDays(-124) };
        //    emp[3] = new Employee3 { EmpId = 4, EmpName = "Swathi", EmpAddress = "America", EmpDob = DateTime.Now.AddDays(-124) };
        //    emp[4] = new Employee3 { EmpId = 5, EmpName = "Nishma", EmpAddress = "Africa", EmpDob = DateTime.Now.AddDays(-124) };
        //    Console.WriteLine(emp.EmpId);

        // }
        static void Main(string[] args)
        {
            Employee3 e1 = new Employee3 { EmpId = 1, EmpName = "Shilpa", EmpDob = DateTime.Parse("02/02/2020") };
            Employee3 e2 = new Employee3 { EmpId = 2, EmpName = "Anisha", EmpDob = DateTime.Parse("03/02/2020") };
            Employee3 e3 = new Employee3 { EmpId = 3, EmpName = "Anuradha", EmpDob = DateTime.Parse("04/02/2020") };
            Employee3 e4 = new Employee3 { EmpId = 4, EmpName = "isha", EmpDob = DateTime.Parse("05/02/2020") };
            Employee3 e5 = new Employee3 { EmpId = 5, EmpName = "Hana", EmpDob = DateTime.Parse("06/02/2020") };
            Console.WriteLine($"EmpID:{e1.EmpId}\nEmpName:{e1.EmpName}\nEmpDob:{e1.EmpDob.ToShortDateString()}");
            Console.WriteLine();
            Console.WriteLine($"EmpID:{e2.EmpId}\nEmpName:{e2.EmpName}\nEmpDob:{e2.EmpDob.ToShortDateString()}");
            Console.WriteLine();
            Console.WriteLine($"EmpID:{e3.EmpId}\nEmpName:{e3.EmpName}\nEmpDob:{e3.EmpDob.ToShortDateString()}");
            Console.WriteLine();
            Console.WriteLine($"EmpID:{e4.EmpId}\nEmpName:{e4.EmpName}\nEmpDob:{e4.EmpDob.ToShortDateString()}");
            Console.WriteLine();
            Console.WriteLine($"EmpID:{e5.EmpId}\nEmpName:{e5.EmpName}\nEmpDob:{e5.EmpDob.ToShortDateString()}");
            Console.Read();



        }



    }
     
  

}
