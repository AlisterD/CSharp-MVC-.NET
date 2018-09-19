using System;

namespace CSharpNotes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course Are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page Number?");
            string pagenumb = Console.ReadLine();
            int pgnumb = Convert.ToInt32(pagenumb);
            Console.WriteLine("Do you need help with anything? Please anwser \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool help1 = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            String experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            float hour1 = float.Parse(hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}