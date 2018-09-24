using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Number would you like to perform calculations on?");
            int userInput = Convert.ToInt32(Console.Read());


            Math MathBook = new Math();

            int userResult1 = MathBook.Addition(userInput);
            Console.WriteLine(userResult1);

            int userResult2 = MathBook.Multiply(userInput);
            Console.WriteLine(userResult2);

            int userResults3 = MathBook.Divide(userInput);
            Console.WriteLine(userResults3);
            Console.ReadLine();
            
        }
            
    }
            
}
