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

        Console.WriteLine("Enter a price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        double vatper = 21.00;
        double total_vat = Math.Round((price / 100) * vatper ,2);
        double total = Math.Round(price +total_vat,2);

        Console.WriteLine("price: " + price + ", VAT: " + total_vat + " Total: " + total);


    }
}