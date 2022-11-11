using System;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generate 20 random number 0-200
            double sum = 0;
            double[] elements = new double[20];
            Random rand = new Random();
            for (int i = 0; i < elements.Length; i++)
            {

                elements[i] = rand.Next(1, 200); ;

            }
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
                Console.WriteLine($"Element {i} is {elements[i]}");
            }
            Console.WriteLine();
            double avg = sum / elements.Length;
            Console.WriteLine($"average:{avg:0.00}");
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                double diff = Math.Abs(avg - elements[i]);
                Console.WriteLine($"Difference between average and element {i} is {diff:0.00}");
            }
        }
    }
}
