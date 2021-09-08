using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day03
{
    class FatherBusiness
    {
        //Father giving permission to change....
        public virtual void AcceptPayment(string paymentMode, double amount)
        {
            if (paymentMode.ToLower() == "cheque" || paymentMode.ToLower() == "cash")
                Console.WriteLine($"Payment of {amount:C} accepted in the form of {paymentMode}");
            else
                Console.WriteLine("Invalid Payment mode");
        }

        public void MakePayment(string payMode, double amount)
        {
            if (payMode != "OnlineBanking")
                Console.WriteLine("Invalid payment");
            else
                Console.WriteLine($"Payment of {amount:C} made in the form of {payMode}");
        }
    }
    //A Class with 2 methods->A Class that has additional method ->3 Methods.
    //Instance of the Base -> Instantiated to Derived class, how many methods  will U get?
    class ChildBusiness : FatherBusiness
    {
        //override is to notify the system that we have changed......
        public override void AcceptPayment(string paymentMode, double amount)
        {
            if (paymentMode.ToLower() == "card" || paymentMode.ToLower() == "cash")
                Console.WriteLine($"Payment of {amount:C} accepted in the form of {paymentMode}");
            else
                Console.WriteLine("Invalid Payment mode");
        }
        //Method hiding...
        public new void MakePayment(string payMode, double amount)
        {
            if (payMode == "OnlineBanking" || payMode == "UPI")
                Console.WriteLine($"Payment of {amount:C} made in the form of {payMode}");
            else
                Console.WriteLine("Invalid payment");
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            //The base class will behave like a derived class object and will now start calling the overriden methods.
            FatherBusiness business = new ChildBusiness();
            business.AcceptPayment("Card", 67000);//Polymorphic behavior
            business.MakePayment("UPI", 60000);//No Polymorphic behavior

            if (business is ChildBusiness)
            {
                var temp = business as ChildBusiness;//safe way of typecasting in C#
                temp.MakePayment("UPI", 60000);
            }
            else
            {
                Console.WriteLine("This is not the child's business");
            }
        }
    }
}
