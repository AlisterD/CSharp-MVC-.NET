using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\CLogs\logs.txt", true))
            {
                file.WriteLine(answer);
            }
            Console.WriteLine("Great! the Answer {0} has been logged in the CLogs Folder located in your Desktop!", answer);
            Console.ReadLine();

        }
    }
}
