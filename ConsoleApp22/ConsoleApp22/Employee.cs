using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Employee
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // Constructor
        public Employee(string FirstName, string LastName, int Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }

        // Method action on the properties 
        public void name()
        {
            Console.WriteLine("Full Name and Id: " + FirstName + " " + LastName +  " " +Id);

        }

    
    }
}
