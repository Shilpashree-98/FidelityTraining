using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day02
{
    class ArraysDemo
    {
      static void Main(string[] args)
        {
            //Create an array dynamically including its size and type...
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the data type of the CTS for the Array to be created");
            Type type = Type.GetType(Console.ReadLine());//Get the type of the data that U want to store

            Array array = Array.CreateInstance(type, size);//Create an array at runtime....
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the index {i} of the data type {type.Name}");
                object value = Convert.ChangeType(Console.ReadLine(), type);
                //Converts the value to the type that U want to....
                array.SetValue(value, i);
            }
            Console.WriteLine("All the values are set!!!!");
            //Use the GetValue method, indexer is not allowed in Array class. 
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array.GetValue(i));
            }
            Console.Read();
        }
    }
}