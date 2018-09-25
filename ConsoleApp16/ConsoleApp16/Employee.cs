using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Employee : Person
    {
        int Id = 100;

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {
         
        }
    }
}
