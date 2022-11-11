using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        // set culture of program
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;
        // your code here...

        Console.WriteLine("Enter 1st number: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number: ");
        float num2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number: ");
        float num3 = float.Parse(Console.ReadLine());

        float avg = (num1 + num2 + num3) / 3;



        Console.WriteLine("The average is : " + avg);


    }
}