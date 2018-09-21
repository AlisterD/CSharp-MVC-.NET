using System;
using System.Collections.Generic;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1) Create a one-dimensional Array of strings. Ask the user to input some text. 
             * Create a loop that goes through each string in the Array, adding the user’s text to the string. 
             * Then create a loop that prints off each string in the Array on a separate line. */
            string[] names = { "Alister", "John", "Matt" };
            string[] answer = new string[4];
            Console.WriteLine("Please enter a name");
            string textInput = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(textInput + " " + names[i]);
                Console.ReadLine();
            }

            /* 2. Create an infinite loop.*/

            //for (int a = 1; a > 0; a++)
            //{
            //    Console.WriteLine("This doesn't have an end, since everything is greater than zero");
            //    Console.ReadLine();
            //}

            /* 3.Fix the infinite loop so it will execute. */
            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("This fixed loop until it reaches the values of less than 3");
                Console.ReadLine();
            }

            /*4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator. */
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This loop compares using < operator");
            }
            /*5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator. */

            for (int i = 0; i <+ 10; i++)
            {
                Console.WriteLine("This loop compares using <= operator");
            }

            /*6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen. */
            List<string> cities = new List<string>() { "Portland", "Salt Lake City", "Atlanta", "New York", "Seattle", "Los Angeles", "Miami" };
            Console.WriteLine("Please type a name of a city: ");
            string city = Console.ReadLine();

            bool match = false;
            for (int i = 0; i < cities.Count; i++)
                if (cities[i].Equals(city))
                {
                    match = true;
                    Console.WriteLine("Found City in the index[" + i + "]:" + cities[i]);
            /*8.Add code to that above loop that stops it from executing once a match has been found. */
                    Console.ReadLine();
                    break;
                }
            /*7.Add code to that above loop that tells a user if they put in text that isn’t in the List. */
            if (!match)
                Console.WriteLine("the city is not found in the array.");
                Console.ReadLine();

            /*9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen. */
            List<string> cities1 = new List<string>() { "Portland", "Salt Lake City", "Atlanta", "New York", "Seattle", "Portland", "Portland" };
            Console.WriteLine("Please enter city to locate in the list");
            string cityInput = Console.ReadLine();

            bool match1 = false;
            for (int i = 0; i < cities1.Count; i++)
                if (cities[i].Equals(cityInput))
                {
                    match1 = true;
                    Console.WriteLine("Found City in the index[" + i + "]:" + cities[i]);
                    Console.ReadLine();
                    break;
                }
            /*10.Add code to that above loop that tells a user if they put in text that isn’t in the List. */
            if (!match1)
                Console.WriteLine("the city is not found in the array.");
            Console.ReadLine();



            /*11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list. */
            List<string> cities2 = new List<string>() { "Portland", "Salt Lake City", "Atlanta", "New York", "Seattle", "Salt Lake City", "Salt Lake City" };
            List<string> repeated = new List<string>();
            bool match3 = false;
            foreach( string str in cities2)
            {
                foreach (string inner in repeated)
                    if (inner.Equals(str))
                        match3 = true;
                Console.WriteLine(str + " - " + match3);
                repeated.Add(str);
                match3 = false;
            }
            Console.ReadLine();

        } 




    }
}






 
 
 
 
 