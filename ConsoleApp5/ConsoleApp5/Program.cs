using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please supply a accurate weight for the package you wish to ship:");
            double packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day. ");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please supply a accurate Width for the package");
            float packageWidth = float.Parse(Console.ReadLine());
            Console.WriteLine("Please supply a accurate Height for the package");
            float packageHeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Please supply a accurate Lenth for the package");
            float packageLength = float.Parse(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                return;
            }

            double results = (packageWidth + packageHeight + packageLength);
            double result1= (((results) * packageWeight) / 100);
            Console.WriteLine("Your estimated total for shipping this package is: $" + result1 + " Thank You.");
            Console.ReadLine();

        }
    }
}
