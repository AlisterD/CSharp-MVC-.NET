using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Math2 Math2 = new Math2();

            // Call the method in the class, passing in two numbers.
            Math2.method(2, 4);

            // Call the method in the class, specifying the parameters by name.
            Math2.method(y: 3, x: 10);
            Console.ReadLine();
        }

    }
}
