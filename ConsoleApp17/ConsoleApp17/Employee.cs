using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Employee : Person, IQuittable 
    {
        int Id = 100;

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }
        public void Quit()
        {
            Console.WriteLine("If you press Enter, you will Exit");
            Console.ReadLine();
            Environment.Exit(0);

        }

        public override void NameofEmployee()
        {
            Console.WriteLine("Name:" + base.FirstName + base.LastName);

        }
    }

    
}
