using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement the body for the following function: static boolean isValidDate(int year, int month, int day) { // do stuff here return false; }

//The function should check if the parameter values constitute a valid calendar date or not. Accordingly return true or false. For example,

//year = 2018, month = 13, day = 1 is an invalid date as the possible values for month is 1 to 12.
//year=2018, month = 2, day = 29 is an invalid date as the maximum days in February is 28 in the year 2018
//year=2016, month = 2, day = 29 is a valid date. Write a program to call the above function multiple times with different values.

namespace Assignment1
{
    class Day1Assignment4
    {
        const int max_valid_year = 9999;
        const int min_valid_year = 1800;
        static bool isLeap(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));

        }
        static bool isValidDate(int d, int m,int y)
        {
            if (y > max_valid_year || y < min_valid_year)
                return false;
            if (m < 1 || m> 12)
                return false;
            if (d < 1 || d > 31)
                return false;
            if(m==2)
            {
                if (isLeap(y))
                    return (d <= 29);
                else
                    return (d <= 28);
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return (d <= 30);
            return true;
        }
        public static void Main(String[] args)
        {
            int date = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            if(isValidDate(date,month,year))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
