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
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a number (0=stop): ");
                int input = int.Parse(Console.ReadLine());
                if (input == 0) break;
                array[i] = input;
            }
            Console.WriteLine();
            Console.Write("Enter searchvalue: ");
            int searchValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of occurences of searchvalue ({searchValue}) is : {CountOccurences(array, searchValue)} ");


        }

        private static string CountOccurences(int[] array, int searchValue)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}
