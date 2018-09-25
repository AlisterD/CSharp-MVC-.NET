using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass myObject = new myClass();
            Console.WriteLine("Please enter a number. The Second inout may be let blank: ");
           string first = Console.ReadLine();
           string second = Console.ReadLine();

            int total;
            if (string.IsNullOrWhiteSpace(second))
            total = myObject.myMethod(Convert.ToInt32(first));
            else
                total = myObject.myMethod(Convert.ToInt32(first) , Convert.ToInt32(second));
            Console.WriteLine("The returned value of both of your numbers is: " + total + "."); 
            Console.ReadLine();


        }
    }
}
