using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day03
{
    class BaseClass
    {
        private void helperFunc()
        {
            Console.WriteLine("Helper to be used inside  this class");
        }
        public void TestBase()
        {
            helperFunc();
            Console.WriteLine("Base Class function");
        }
        protected void familyFunc() => Console.WriteLine("Called by itself and its derived classes");

        internal void AssemblyFunc() => Console.WriteLine("Accessible by any class within the same project");
    }
    //No access specifier for the base class while inheriting it. C# does not support private or public inheritance.
    //All the base class members retain their access levels in the derived class. Private members of the base class are inaccessible to the derived.  
    class DerivedClass : BaseClass
    {
        public void CallBaseFunc()
        {
            familyFunc();
            AssemblyFunc();
            TestBase();
        }
    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            DerivedClass cls = new DerivedClass();
            cls.TestBase();
            cls.AssemblyFunc();
            //Derived class objects created outside the class cannot access their private and protected methods.  
        }
    }
}
