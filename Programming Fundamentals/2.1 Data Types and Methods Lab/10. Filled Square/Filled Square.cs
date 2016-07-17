using System;

public class Substring_broken
{

    static void PrintHeader(int n)
    {
        Console.WriteLine(new string('-', 2 * n));

    }


    static void PrintMiddleRow(int n)
    {


        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('-');

            for (int q = 0; q < n - 1; q++)
            {

                Console.Write("\\/");

            }

            Console.Write('-');
            Console.WriteLine();
        }




    }

    public static void Main()
    {


        int n = int.Parse(Console.ReadLine());

        PrintHeader(n);
        PrintMiddleRow(n);
        PrintHeader(n);

    }
}