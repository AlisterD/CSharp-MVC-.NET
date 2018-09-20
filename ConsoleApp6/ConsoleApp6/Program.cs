using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
      
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            string dateString = DateTime.Today.ToShortDateString();
            Console.ReadLine();

            Console.WriteLine("Hello " + userName + ". Please write your middle initial:");
            string middleName = Console.ReadLine();
            Console.ReadLine();

            string str = "Hello " + userName + " " + middleName + ". Today is " + dateString + ".";
            Console.WriteLine(str + "Press ENTER");
            Console.ReadLine();

            str += " How are you today?";
            Console.WriteLine(str);
            Console.ReadLine();

            Console.WriteLine("Oh great! if you were wondering... your name in Upper case is:");
            userName = userName.ToUpper();
            Console.WriteLine(userName);
            Console.ReadLine();

            StringBuilder mySb = new StringBuilder();
            mySb.Append("Hi again! " + userName);
            Console.WriteLine(mySb);
            Console.ReadLine();

            mySb.Append(" I wanted to tell you that you are awesome!");
            Console.WriteLine(mySb);
            Console.ReadLine();

            mySb.Append(".... and this is the enter of the story! bye!");
            Console.WriteLine(mySb);
            Console.ReadLine();



        }
    }
}
