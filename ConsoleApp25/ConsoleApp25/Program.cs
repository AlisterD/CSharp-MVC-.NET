using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            const string type = "Is this a const?";
            Console.WriteLine(type);
            var number = 3;
            var letters = "ABC";
            Console.WriteLine(number.GetTypeCode());
            Console.WriteLine(letters);
            Store store = new Store();
            store.Complete();
            Console.ReadLine();
        }
    }
}
