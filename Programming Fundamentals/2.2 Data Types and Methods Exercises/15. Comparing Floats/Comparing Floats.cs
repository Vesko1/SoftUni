using System;
class Program
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());


        double c =  Math.Abs(a - b);

        if (c < 0.000001)
        {

            Console.WriteLine(true);
        }

        else
        {
            Console.WriteLine(false);
        }
    }
} 