using System;
using System.Collections.Generic;


namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be divided by 2 and then passed out via a paramenter: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int one, two, output;

            myClass MyObject = new myClass();
            MyObject.mathProb1(out output, input);
            Console.WriteLine("The total by 2" + output);
            Console.WriteLine("Please enter two numbers in the next two lines");
            MyObject.method2(out one, out two);
            Console.WriteLine("Values plus secondpart:" + one + ", " + two);

            Console.WriteLine(MyStaticClass.check());
            Console.Read();
            

        }
    }
}
