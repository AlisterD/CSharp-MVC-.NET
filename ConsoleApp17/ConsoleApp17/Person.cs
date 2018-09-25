using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public abstract class Person
    {
       public string FirstName;
       public string LastName;
        public Person(String FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public void sayName()
        {
            Console.WriteLine("Name:" + "[" + FirstName + " " + LastName + "]");
        }
        public abstract void NameofEmployee();
    }
}
