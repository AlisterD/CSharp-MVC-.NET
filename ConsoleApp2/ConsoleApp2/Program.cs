using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please press ENTER once after each request - Enjoy! ");
            Console.ReadLine();

            Console.Write("Please write a number: ");
            string number = Console.ReadLine();
            int multiplication = Convert.ToInt32(number);
            int totalmult = multiplication * 50;
            Console.WriteLine(multiplication + " times 50 is: " + totalmult);
            Console.ReadLine();

            Console.Write("Please write another number: ");
            string add = Console.ReadLine();
            int suma = Convert.ToInt32(add);
            int sumatotal = suma + 25;
            Console.WriteLine(suma + " plus 25 is: " + sumatotal);
            Console.ReadLine();

            Console.Write("Please write a number to be divided by 12.5: ");
            string div = Console.ReadLine();
            double divide = Convert.ToDouble(div);
            double dividetotal = divide / 12.5;
            Console.WriteLine("Great! " + divide + " divided by 12.5 is: " + dividetotal);
            Console.ReadLine();

            Console.WriteLine("Almost done... Please enter another number please:");
            string greater = Console.ReadLine();
            int great = Convert.ToInt32(greater);
            bool boolvalue = great > 50;
            Console.Write("Now, lets check if this number is greater than 50: " + boolvalue);
            Console.ReadLine();

            Console.WriteLine("last one, I promise! Please type a number to be divided by 7: ");
            string remainder1 = Console.ReadLine();
            int remainder = Convert.ToInt32(remainder1);
            double remaindertotal = remainder % 7.0;
            Console.WriteLine("The remainder of " + remainder + " dived by 7 is to: " + remaindertotal);
            Console.WriteLine();
            Console.WriteLine("See? Done and done! Thank you!");
            Console.ReadLine();


        }
    }
}
