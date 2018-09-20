using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            //Person 1 info
            Console.Write("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("What is person's 1 hourly rate?");
            String personRate1 = Console.ReadLine();
            float personRateHr1 = float.Parse(personRate1);
            Console.WriteLine("how many hours does person 1 work per week");
            string hourPerWeek1 = Console.ReadLine();
            float hourPerWeekP1 = float.Parse(hourPerWeek1);
            Console.ReadLine();

            //Person 2's info
            Console.WriteLine("Person 2");
            Console.WriteLine("What is Person 2's Hourly rate");
            String personRate2 = Console.ReadLine();
            float personRateHr2 = float.Parse(personRate2);
            Console.WriteLine("How many hours does Person 2 work per week");
            String hourPerWeek2 = Console.ReadLine();
            float hourPerWeekP2 = float.Parse(hourPerWeek2);
            Console.ReadLine();

            //Salary
           float p1Salary = (personRateHr1 * hourPerWeekP1 * 52);
           float p2Salary = (personRateHr2 * hourPerWeekP2 * 52);
           string p1HrSalary = Convert.ToString(p1Salary);
           string p2HrSalary = Convert.ToString(p2Salary);

            //Printing annual salary for Person 1 and for Person 2
            Console.WriteLine("These are the annual salerys for Person 1 and for Person 2");
            Console.WriteLine("The Yearly Salery for Person 1 is " + "$" + p1HrSalary);
            Console.WriteLine("The Yearly Salery for Person 2 is " + "$" + p2HrSalary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compariosn = p1Salary > p2Salary;
            string comp = Convert.ToString(compariosn);
            Console.WriteLine(comp);
            Console.ReadLine();



        } 
   
    }
}
