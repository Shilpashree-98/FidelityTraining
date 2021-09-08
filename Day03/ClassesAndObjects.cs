using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Day02;
namespace Assignment1.Day03
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime BillDate { get; set; }
        public double BillAmount { get; set; }
    }

    class ClassesAndObjects
    {
        private const int cstSize = 10;
        private static Customer[] _customers = new Customer[cstSize];

        static string getMenu()
        {
            string menu = "-------------------CUSTOMER MANAGEMENT SOFTWARE--------------------\n";
            menu += "TO ADD CUSTOMER---------------->PRESS 1\n";
            menu += "TO DELETE CUSTOMER---------------->PRESS 2\n";
            menu += "TO UPDATE CUSTOMER---------------->PRESS 3\n";
            menu += "TO FIND CUSTOMER---------------->PRESS 4\n";
            return menu;
        }
        static void Main(string[] args)
        {
            bool tryAgain = true;
            do
            {
                string menu = getMenu();
                int choice = MyConsole.GetNumber(menu);
                tryAgain = processMenu(choice);
            } while (tryAgain);

            //firstDemo();
            //objectArrayDemo();
        }
        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    createNewCustomer();
                    Console.WriteLine("Customer added successfully");
                    break;
                case 2:
                    deleteCustomer();
                    break;
                case 3:
                    updateCustomer();
                    break;
                case 4:
                    findCustomer();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void findCustomer()
        {
            string nameToFind = MyConsole.GetString("Enter the name or part of the name to search");
            foreach (var cst in _customers)
            {
                if (cst != null && cst.CustomerName.Contains(nameToFind))
                {
                    Console.WriteLine($"The Name: {cst.CustomerName} from {cst.CustomerAddress} who has billed an amount of {cst.BillAmount:C} dated {cst.BillDate.ToShortDateString()}");
                }
            }
        }

        private static void updateCustomer()
        {
            throw new NotImplementedException("DO this as assignment");
        }

        private static void deleteCustomer()
        {
            int idToDelete = MyConsole.GetNumber("Enter the ID of the customer to delete");
            for (int i = 0; i < cstSize; i++)
            {
                if (_customers[i] != null && _customers[i].CustomerID == idToDelete)
                {
                    _customers[i] = null;//We dont have delete in C#. U simply assign it to null
                    Console.WriteLine($"Customer with ID {idToDelete} has been deleted");
                    return;
                }
            }
            Console.WriteLine($"Customer with ID {idToDelete} does not exist");
        }

        private static void createNewCustomer()
        {
            var name = MyConsole.GetString("Enter the Name");
            var address = MyConsole.GetString("Enter the Billing Address");
            var id = MyConsole.GetNumber("Enter the ID");
            var date = MyConsole.GetDate("Enter the date of Billing");
            var amount = MyConsole.GetDouble("Enter the Billing amount");

            for (var i = 0; i < cstSize; i++)//find the first occurance of null in the array
            {
                if (_customers[i] == null)
                {
                    _customers[i] = new Customer
                    {
                        BillAmount = amount,
                        BillDate = date,
                        CustomerAddress = address,
                        CustomerID = id,
                        CustomerName = name
                    };
                    return;//exit the function...
                }
            }
        }
        private static void objectArrayDemo()
        {
            //Default value of any reference type is null. U cannot access that object unless U instantiate it. 
            var customers = new Customer[10];//U have instantiated the array of objects. But the objects inside it are having default values(null).
            customers[0] = new Customer { CustomerID = 1, CustomerName = "Rajesh", CustomerAddress = "Mysore", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-12) };
            customers[1] = new Customer { CustomerID = 12, CustomerName = "Kumar", CustomerAddress = "Chennai", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-124) };
            customers[2] = new Customer { CustomerID = 13, CustomerName = "Shiva", CustomerAddress = "New Delhi", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-14) };
            customers[3] = new Customer { CustomerID = 14, CustomerName = "Swetha", CustomerAddress = "Pune", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-4) };
            customers[4] = new Customer { CustomerID = 15, CustomerName = "Radha", CustomerAddress = "Hassan", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-24) };
            customers[5] = new Customer { CustomerID = 16, CustomerName = "Sampath", CustomerAddress = "Mysore", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-42) };
            customers[6] = new Customer { CustomerID = 17, CustomerName = "Mohan", CustomerAddress = "Bangalore", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-14) };
            customers[7] = new Customer { CustomerID = 18, CustomerName = "Aravind", CustomerAddress = "Tumkur", BillAmount = 6000, BillDate = DateTime.Now.AddDays(-1) };

            foreach (var cst in customers)
            {
                Console.WriteLine(cst != null ? cst.CustomerName : "Not available");
            }
        }

        private static void firstDemo()
        {
            //Class by itself is like a blueprint
            Customer cst = new Customer { CustomerID = 123, BillAmount = 5600, BillDate = DateTime.Parse("12/12/2010"), CustomerAddress = "RR Nagar, Bangalore", CustomerName = "Phaniraj" }; //New syntax of C# 4.0 
            Console.WriteLine(cst);//What happens?: It by default converts the object to a string representation and displays it on the console.
            Console.WriteLine($"The Name: {cst.CustomerName} from {cst.CustomerAddress} who has billed an amount of {cst.BillAmount:C} dated {cst.BillDate.ToShortDateString()}");
        }
    }
}
