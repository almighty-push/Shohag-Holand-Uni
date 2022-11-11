using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = 0;
                int i = 2;
                Console.Write("Enter a number:");
                number = int.Parse(Console.ReadLine());
                if (number < 1) break;
                while (number > 1)
                {
                    if (number % i == 0)
                    {
                        Console.Write(i + " ");
                        number = number / i;
                    }
                    else
                    {
                        i++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
