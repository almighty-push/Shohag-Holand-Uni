using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        //enter second
        Console.WriteLine("Enter the number of seconds:");
        int seconds = Convert.ToInt32(Console.ReadLine());

        //convert to hh:mm:ss
        var hours = seconds / 3600;
        var minutes = (seconds % 3600) / 60;
        var secondsLeft = (seconds % 3600) % 60;
        Console.WriteLine("The time is: {0}:{1}:{2}", hours, minutes, secondsLeft);


    }
}