using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Number decimalNumber = new Number();
            decimalNumber.Amount = 10.9123m;

            Console.WriteLine(decimalNumber.Amount);
            Console.ReadLine();



        }
    }
}
