﻿using System;

class Program
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < num; i++)
        {


            sum += Fibonacci(i);

        }
        Console.WriteLine(++sum);
    }
}