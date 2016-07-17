using System;
using System.Collections.Generic;
using System.Numerics;



public static class PrimeTool
{

    
    public static void Main()
    {



        BigInteger num = BigInteger.Parse(Console.ReadLine());


        BigInteger factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;

        }

        Console.WriteLine(factorial);

    }
}