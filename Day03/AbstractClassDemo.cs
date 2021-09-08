using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day03
{
    abstract class AbsClass
    {
        public void NormalMethod() => Console.WriteLine("Implemented here itself!!!!!");
        public virtual void VirtualMethod() => Console.WriteLine("Implemented here but can be modified by derived");
        public abstract void AbstractMethod();//Not clear on its implementation
    }
    //U must implement all the abstract methods of the class, else it should also be marked as abstract
    class ImplAbsClass : AbsClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Implemented more presisely in the derived class");//Now clear and will be implemented. 
        }
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            AbsClass cls = new ImplAbsClass();
            cls.NormalMethod();
            cls.VirtualMethod();
            cls.AbstractMethod();
        }
    }
}
