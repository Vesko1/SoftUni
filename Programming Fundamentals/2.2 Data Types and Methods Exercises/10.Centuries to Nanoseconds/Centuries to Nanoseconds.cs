using System;
class Program
{
    static void Main()
    {


        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        decimal hours = 24m * days;
        decimal minutes = 60m * hours;
        decimal seconds = 60m * minutes;
        decimal mili = 1000m * seconds;
        decimal micro = 1000m * mili;
        decimal nano = 1000m * micro;


        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, mili, micro, nano);







    }
}