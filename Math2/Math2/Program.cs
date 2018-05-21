using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathOp mathObject = new MathOp();
            Console.WriteLine("501 divided by 2 gives us a remainder of: " + mathObject.MathOverload(501));
            Console.WriteLine("7.1365 * 7, then rounded to a whole number gives us " + mathObject.MathOverload(7.1365m));
            Console.WriteLine("A string object of 10 converted to Int32 + 5 is " + mathObject.MathOverload("5") + ". If I gave it something that it couldn't convert to an int, the program would auto-insert 5.");
            Console.ReadLine();
        }
    }
}
