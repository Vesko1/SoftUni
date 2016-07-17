using System;
using System.Collections.Generic;
using System.Linq;

class LAstKNumbers
{
    static void Main(string[] args)
    {



        var arr1 = Console.ReadLine().Split(' ');
        var arr2 = Console.ReadLine().Split(' ');

        int a = Math.Min(arr1.Length, arr2.Length);
        int b = Math.Max(arr1.Length, arr2.Length);

        int left = 0;
        int right = 0;


        for (int i = 0; i < a; i++)
        {
            if (arr2[i] == arr1[i])
            {
                left++;
            }

        }
           int l2 = arr2.Length-1;
           int l1 = arr1.Length-1;

        while (a > 0)
        {

            if (arr2[l2] == arr1[l1])
            {
                right++;
            }

            a--;
            l1--;
            l2--;
        }


        Console.WriteLine(left > right ? left : right);



    }
}