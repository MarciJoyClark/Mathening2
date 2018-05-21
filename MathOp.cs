using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math2
{
    public class MathOp
    {
        public int MathOverload(int number)
        {
            int newNumber = number % 2;
            return newNumber;
        }
        public int MathOverload(decimal number)
        {
            int newNumber = Convert.ToInt32(number * 7);
            return newNumber;
        }
        public int MathOverload(string number)
        {
            try
            {
                int newNumber = Convert.ToInt32(number) + 10;
                return newNumber;
            }
            catch (FormatException)
            {
                return 5;
            }
        }
    }
}
