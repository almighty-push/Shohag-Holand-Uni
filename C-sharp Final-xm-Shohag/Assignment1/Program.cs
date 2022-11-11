using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "", answer2="";
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.Write($"{name}, is this your first bachelor study?");
             answer = Console.ReadLine();

            if (answer == "no")
            {
                Console.WriteLine("your college fees for this year is full price (2209.00 euro)");
            }
            if (answer == "yes")
            {
                Console.Write("is it a teacher training program?");
                 answer2 = Console.ReadLine();
            }
            if (answer2 == "no")
            {
                Console.WriteLine("your college fees for this year is half the price (1104.50 euro), next year full price");
            }
            if (answer2 =="yes")
            {
                Console.WriteLine("your college fees for this year is half the price (1104.50 euro), next year also half the price");
            }
        }
    }
}
