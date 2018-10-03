using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type a number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0} on:", answer);
            Console.WriteLine(DateTime.Now);
            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(answer);
            Console.WriteLine("Time in {0} hours: {1}", answer, later.TimeOfDay);
            Console.ReadLine();


        }
    }
}
