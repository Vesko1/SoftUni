﻿using System;
class Program
{
    static void Main()
    {

        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(input, 16).ToUpper());
        Console.WriteLine(Convert.ToString(input, 2));

        


    }
} 