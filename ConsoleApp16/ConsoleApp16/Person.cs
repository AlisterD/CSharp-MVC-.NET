using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
   public class Person
    {
        string FirstName;
        string LastName;
        public Person(String FirstName, string LastName)
        {
           this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public void sayName()
        {
            Console.WriteLine("Name:" + "[" + FirstName + " " + LastName + "]");
        }
       
    }
}
