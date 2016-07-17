using System;
using System.Linq;

class LAstKNumbers
{
    static void Main(string[] args)
    {



        var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = arr1.Length;

        if (arr1.Length == 1)
        {

            Console.WriteLine(arr1[0]); 
        }

        else if (n % 2 == 0)
        {
            int start = n / 2 - 1;
            int end = n / 2 + 1;
            int[] temp = new int[end - start];
            int a = 0;

            for (int i = start; i < end; i++)
            {
                temp[a] = arr1[i];
                a++;
            }

            Console.Write("{ ");
            Console.Write(string.Join(",", temp));
            Console.Write(" }");

        }
        else if (n % 2 == 1)
        {
            int start = n / 2 - 1;
            int end = n / 2 + 2;
            int[] temp = new int[end - start];
            int a = 0;

            for (int i = start; i < end; i++)
            {
                temp[a] = arr1[i];
                a++;
            }

            Console.Write("{ ");
            Console.Write(string.Join(",", temp));
            Console.Write(" }");

        }



    }
}