using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day02
{
    class Employee
    {
        //fields will be local to the class 
        int empId;
        string empName;
        string empAddress;
        public int EmpID
        {
            get { return empId; }
            set { empId = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public string EmpAddress
        {
            get { return empAddress; }
            set { empAddress = value; }
        }

    }
}

       
 