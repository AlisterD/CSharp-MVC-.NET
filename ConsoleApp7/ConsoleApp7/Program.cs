using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            //Arrays and List Creation

            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] strArray = { "Mon", "Tu", "Wed", "Th", "Fr", "Sat", "Sun" };
            List<string> strList = new List<string>();
            strList.Add("Jan");
            strList.Add("Feb");
            strList.Add("Mar");
            strList.Add("Apr");
            strList.Add("May");
            strList.Add("Jun");
            strList.Add("Jul");
            strList.Add("Aug");
            strList.Add("Sept");
            strList.Add("Oct");
            strList.Add("Nov");
            strList.Add("Dec");


            // Ask the user to select an index of the Array and then display the integer at that index on the screen.

            bool askUser = true;
            while (askUser)
            {
                Console.WriteLine("Please select an index from 0  to 9: ");
                int numberSelection = Convert.ToInt32(Console.ReadLine());
                bool isThisInsideArray = false;
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (numberSelection == i)
                    {
                        Console.WriteLine("You selected: " + numArray[i]);
                        isThisInsideArray = true;
                        Console.ReadLine();
                        askUser = false;
                    }
                }
                if (isThisInsideArray == false)
                {
                    Console.WriteLine("This day index doesn't exist, please try again: ");
                }
            }


            // Ask the user to select an index of the Array and then display the string at that index on the screen.

            bool askUser2 = true;
            while (askUser2)
            {
                Console.WriteLine("Please select an index number from 0 to 6 ");
                int weekSelection = Convert.ToInt32(Console.ReadLine());
                bool isWeekInsideArray = false;
                for (int w = 0; w < strArray.Length; w++)
                {
                    if (weekSelection == w)
                    {
                        Console.WriteLine("You selected: " + strArray[w]);
                        isWeekInsideArray = true;
                        Console.ReadLine();
                        askUser2 = false;
                    }
                }
                if (isWeekInsideArray == false)
                {
                    Console.WriteLine("This week index doesn't exist, please try again: ");
                }
            }

            // Ask the user to select an index of the Array and then display the string at that index on the screen.
           
            bool askUser3 = true;
            while (askUser3)
            {
                Console.Write("Please select an index from 0 to 11 ");
                int monthSelection = Convert.ToInt32(Console.ReadLine());
                bool isMonthInsideArray = false;
                if (monthSelection < strList.Count && monthSelection >= 0)
                {
                    Console.WriteLine("You selected: " + strList[monthSelection]);
                    isMonthInsideArray = true;
                    Console.ReadLine();
                    askUser3 = false;
                }
                else Console.WriteLine("This day index doesn't exist, please try again: ");
            }

        }
    }
}


 