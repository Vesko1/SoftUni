using System;
using System.Collections.Generic;
using System.Linq;



public static class PrimeTool
{


    public static void Main()
    {


        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i <  n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
       
        Console.WriteLine(array.Sum());
        Console.WriteLine(array.Min());
        Console.WriteLine(array.Max());
        Console.WriteLine(array.First());
        Console.WriteLine(array.Last());
        Console.WriteLine(array.Average());

    }

}