using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Answer Yes or No:");
            string DUI = Console.ReadLine();
            bool DUIB = (DUI == "No"|| DUI == "no");
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticket1 = Convert.ToInt32(ticket);
            Console.WriteLine("Qualified?");
            bool results = (age1 > 15 && ticket1 <= 3);
            bool results1 = (DUIB && results);
            Console.WriteLine(results1);
            Console.ReadLine();


        }
    }
}
