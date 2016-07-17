using System;
using System.Collections.Generic;
using System.Numerics;



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
        Array.Reverse(array);

        Console.WriteLine(string.Join(" ", array));
        
        
}

}