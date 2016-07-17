using System;
using System.Collections.Generic;
using System.Numerics;



public static class PrimeTool
{


    public static void Main()
    {

        string[] days = new string[] { "Nothing", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int n = int.Parse(Console.ReadLine());



        if (n > 0 && n < 8)
        {
            Console.WriteLine(days[n].ToLower());
        }
        else
        {

            Console.WriteLine("Invalid Day!");
        }
        

}

}