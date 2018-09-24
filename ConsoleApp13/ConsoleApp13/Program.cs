using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            //In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.

            Class1 method = new Class1();
            Console.WriteLine(method.method(12));



            //In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

            Console.WriteLine(method.method(9));


            //In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.

            Console.WriteLine(method.method(100));
            Console.ReadLine();
        }
    }
}
