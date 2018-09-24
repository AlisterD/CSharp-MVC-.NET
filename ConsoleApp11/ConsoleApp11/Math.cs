using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Math
    {
        public int Addition(int userInput)
        {
            userInput = userInput + 10;

            return userInput;
        }

        public int Multiply(int userInput)
        {
            return userInput * 10;
        }
        public int Divide(int userInput)
        {
            return userInput / 10;
        }
    }
}
