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
            //20 random nymber 0-149
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 150);
            }
            //print array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element " + i + " = " + array[i] + "\n");
            }
            Console.WriteLine();
            //find min
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            //find how many times min appears
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    count++;
                }
            }
            //print min and how many times it appears
            Console.WriteLine("smallest number: " + min);
            Console.WriteLine("number of occurence = " + count);
            Console.ReadLine();
            
        }
    }
}
