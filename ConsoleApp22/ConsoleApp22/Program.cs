using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee("David", "Vergara", 1));
            EmployeeList.Add(new Employee("Alister", "Cedeno", 2));
            EmployeeList.Add(new Employee("Steven", "Morrison", 3));
            EmployeeList.Add(new Employee("Kyle", "Oak", 4));
            EmployeeList.Add(new Employee("Finn", "Clay", 5));
            EmployeeList.Add(new Employee("Joe", "Ash", 6));
            EmployeeList.Add(new Employee("Doreen", "McDaniel", 7));
            EmployeeList.Add(new Employee("Jessica", "Marriott", 8));
            EmployeeList.Add(new Employee("Audrey", "Anstead", 9));
            EmployeeList.Add(new Employee("Joe", "Doe", 10));


            List<Employee> JoeNames = new List<Employee>();
            foreach (Employee a in EmployeeList)
            {
                if (a.FirstName.Equals("Joe"))
                    JoeNames.Add(a);
            }


            foreach (Employee a in JoeNames)
            {
                a.name();
            }
            Console.ReadLine();

            JoeNames.Clear();
            EmployeeList.ForEach(i => 
            { if (i.FirstName.Equals("Joe")) JoeNames.Add(i); }
            );

            Console.WriteLine("The new Joe List using Lambda Expression: ");
            foreach(Employee b in JoeNames)
            {
                b.name();
            }
            Console.ReadLine();

            List<Employee> EmployeeWithId5 = new List<Employee>();

            EmployeeList.ForEach(x =>
            { if (x.Id > 5) EmployeeWithId5.Add(x); });

            Console.WriteLine("The Employee List with Id's > 5 are: ");
            foreach(Employee c in EmployeeWithId5)
            {
                c.name();
            }
            Console.ReadLine();

        } 
    }
}
