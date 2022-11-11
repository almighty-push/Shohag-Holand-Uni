using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            int lowest = 100;
            int highest = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
                if (array[i] < lowest)
                {
                    lowest = array[i];
                }
                if (array[i] > highest)
                {
                    highest = array[i];
                }
            }
            Console.WriteLine($"Lowest value: {lowest}");
            Console.WriteLine($"Highest value: {highest}");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= lowest + 20 && array[i] <= highest - 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (array[i] >= lowest + 10 && array[i] <= highest - 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(array[i] + " ");
            }
            Console.ResetColor();
            
        }
    }
}
