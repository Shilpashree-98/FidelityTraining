using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day02
{
    class ParametersDemo
    {
        //PassByValue:
        static void simpleFunc(out int v1)
        {
            v1 = 123;
            Console.WriteLine($"v1: {v1}");//123
        }
        static long addNumbers(int firstVal, params int[] values)
        {
            long res = firstVal;
            foreach (var item in values)
            {
                res += item;
            }
            return res;
        }
        static void mathFunc(int v1, int v2, out int add, out int sub, out int mul, ref int div)
        {
            add = v1 + v2;
            sub = v1 - v2;
            mul = v1 * v2;
            if (v2 != 0)
                div = v1 / v2;
        }
        static void Main(string[] args)
        {
            int v1 = 321;
            simpleFunc(out v1);//A Copy of the variable will be pushed into the function, the original variable will still be in the caller's scope. 
            Console.WriteLine($"v1: {v1}");//What will be the result of v1? 123

            /////////////////////////Out parameter////////////////////////
            int res1, res2, res3, res4 = 0;
            mathFunc(123, 0, out res1, out res2, out res3, ref res4);//The original value will be passed into the function, so any change U make to the value in the function will be reflected back to the caller after the function returns. 
            Console.WriteLine($"The Added: {res1}\nSubtracted: {res2}\nMultipled: {res3}\nDivided:{res4}");

            /////////////////Params//////////////////////////////////
            var lVal = addNumbers(123, 45, 56, 45, 34, 45, 34, 45);
            Console.WriteLine("The res: " + lVal);
            Console.Read();
        }
    }
}
