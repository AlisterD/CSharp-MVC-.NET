using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Class1
    {
        public int method(int x)
        {
            return x + 10;
            
        }

        public int method(decimal y)
        {
            return Convert.ToInt32(y / 7);
            
        }
        public int method(string s)
        {

            int b = Convert.ToInt32(s) + 20;
            return b;

          
        }


    }

}
