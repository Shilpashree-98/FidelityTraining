using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Day02
{
    class MyConsole
    { 
    public static int GetNumber(string question)
    {
        int result;
    TRYAGAIN:
        Console.WriteLine(question);
        if (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Input value should be a valid number");
            goto TRYAGAIN;
        }
        return result;
    }

    public static double GetDouble(string question)
    {
        double result;
    TRYAGAIN:
        Console.WriteLine(question);
        if (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Input value should be a valid number");
            goto TRYAGAIN;
        }
        return result;
    }

    public static DateTime GetDate(string question)
    {
        DateTime result;
    TRYAGAIN:
        Console.WriteLine(question);
        if (!DateTime.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Given value is not a valid Date");
            goto TRYAGAIN;
        }
        return result;
    }

}
}
