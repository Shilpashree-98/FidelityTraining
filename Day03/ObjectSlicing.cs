using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day03
{
    class BaseType
    {
        public void BaseFunc() => Console.WriteLine("Base Func");
    }

    class DerivedType : BaseType
    {
        public void DerivedFunc() => Console.WriteLine("Derived Func");
    }
    class ObjectSlicing
    {
        static void Main(string[] args)
        {
            BaseType type = new BaseType();
            type.BaseFunc();

            BaseType example = new DerivedType();
            example.BaseFunc();//New methods of the derived are inaccessible to the base type object.
            if (example is DerivedType)//U should typecast it to the derived type and with it U should call the method. 
            {
                var temp = example as DerivedType;
                temp.DerivedFunc();
            }

        }
    }
}
