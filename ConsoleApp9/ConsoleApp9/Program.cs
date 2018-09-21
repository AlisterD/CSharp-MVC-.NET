using System;
using System.Collections.Generic;


namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 2, 4, 6, 8, 10, 12, 16, 18 };
                Console.WriteLine("Type a number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the tne entire list by " + numberOne);
                foreach (int i in numbers)
                {
                    int total = i / numberOne;
                    Console.WriteLine(total);
                    Console.ReadLine();
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
