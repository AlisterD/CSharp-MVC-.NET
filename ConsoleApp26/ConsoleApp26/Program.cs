using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("How old are you?");
            int answer = 0;
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer < 0)
                    throw new InvalidOperationException();
              
            }
           catch (InvalidOperationException)
            {
                Console.WriteLine("You are not negative years old! Please be honest: ");
                goto Start;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only digits");
                goto Start;
            }
            Console.WriteLine("I think you were born in:" + DateTime.Now.AddYears(-answer).Year);
            Console.ReadLine();
        }
    }
}
