using System;

public static class PrimeTool
{

    static bool isPrime(long number)
    {
        //  bool isprime = false;

        if (number == 0)
        {
            return false;

        }
        if (number == 1)
        {
            return false;

         }

        if (number == 2)
        {
            return true;
        }
        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
        {
            if (number % i == 0)
            {
                return false;
                
            }
         

        }

        return true;

    }


    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        bool result = isPrime(n);
        Console.WriteLine(result);

    }
}