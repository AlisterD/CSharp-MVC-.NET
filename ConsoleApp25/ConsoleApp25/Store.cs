using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Store
    {
        string Name;
        string Location;

        public Store() : this("Alpha", "NYC"){}

        public Store(string Name, string Location)
        {
            this.Name = Name;
            this.Location = Location;
           
        }
        public void Complete()
        {
            Console.WriteLine("The name of the store is {0} and it is located in {1}", Name, Location);
        }
    }
}
