using ConsoleApp18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee("same", "lastname") { Id = 1 };
            Employee EA = new Employee("same", "lastname") { Id = 2 };
            Employee EB = new Employee("differentName", "differentlastname") { Id = 1 };
            

            Console.WriteLine("Comparing employees:" + Convert.ToString(E == EA));
            Console.WriteLine("Comparing employees:" + Convert.ToString(E == EB));
            Console.ReadLine(); 
        }


    }
}
