using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
          
         
            Console.WriteLine("Please enter a day of the week");
            Start:
            String Answer = Console.ReadLine();

            Days input;
             
            try
            {
                if (Answer.All(char.IsDigit))
                    throw new Exception();
                input = (Days)Enum.Parse(typeof(Days), Answer);
            }
            catch (Exception a)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                goto Start;
            }

            Console.WriteLine("Good Job");
            Console.ReadLine();


        }
    }
    enum Days
    {
        Monday,
        Tuesday,
        Wedneday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
