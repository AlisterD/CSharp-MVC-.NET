using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> List1 = new Employee<string>(); 
            List1.Things.Add("SLC");
            List1.Things.Add("PDX");
            List1.Things.Add("ATL");

            Employee<int> List2 = new Employee<int>();
            List2.Things.Add(100);
            List2.Things.Add(200);
            List2.Things.Add(300);

            Console.WriteLine("Int list: ");
            List2.Things.ForEach(a => Console.WriteLine(a));
            Console.WriteLine("String list: ");
            List1.Things.ForEach(b => Console.WriteLine(b));

            Console.ReadLine();
        }
    }
}
