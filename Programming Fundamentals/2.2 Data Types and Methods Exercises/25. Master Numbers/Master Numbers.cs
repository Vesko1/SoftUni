using System;
using System.Collections.Generic;
using System.Numerics;



public static class PrimeTool
{

    static bool PalChecker(int num)
    {

        int n = num;
        int dig;
        int rev = 0;

        while (num > 0)
        {
            dig = num % 10;
            rev = rev * 10 + dig;
            num = num / 10;
        }

        return (n == rev);

    }

    static bool SummOfDigits(int n)
    {

        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return (sum % 7 == 0);
    }


    static bool EvenDigit(int num)
    {
        int digit;
        bool even = false;
        while (num != 0)
        {
            digit = num % 10;

            if (digit % 2 == 0)
            {

                even = true;
                break;
            }
            num /= 10;
        }

        return even;
        
    }




    public static void Main()
    {
        int end = int.Parse(Console.ReadLine());


        for (int i = 0; i <= end; i++)
        {

            if (PalChecker(i) && SummOfDigits(i) && EvenDigit(i))
            {
                Console.WriteLine(i);
            }


        }

    }
}