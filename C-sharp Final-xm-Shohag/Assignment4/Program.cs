using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend = 0;
            int divisor = 0;
            int remainder = 0;
            int quotient = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                dividend = random.Next(1, 50);
                divisor = random.Next(1, 5);
                quotient = IntegerDivision(dividend, divisor, out remainder);
                Console.WriteLine($"{dividend} / {divisor} \t= {quotient}\t({remainder})");
            }
            
        }
        static int IntegerDivision(int dividend, int divisor, out int remainder)
        {
            int quotient = 0;
            remainder = 0;
            while (dividend >= divisor)
            {
                dividend -= divisor;
                quotient++;
            }
            remainder = dividend;
            return quotient;
        }
    }
}
