using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class myClass
    {
        public void mathProb1(out int outputVar, int input1)
        {
            outputVar = input1 / 2;
        }

        public void method2(out int x, out int y, int secondpart = 0)
        {
            x= Convert.ToInt32(Console.ReadLine()) + secondpart;
            y = Convert.ToInt32(Console.ReadLine()) + secondpart;
        }

        public void method2(out double x, out double y, int secondpart = 0)
        {
            x= Convert.ToInt32(Console.ReadLine()) + secondpart;
            y= Convert.ToInt32(Console.ReadLine()) + secondpart;
        }


    }
}
