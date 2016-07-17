using System;
using System.Linq;
using System.Collections.Generic;

class Program
{

    static void Main()
    {

        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();


       var b = a.OrderByDescending(x =>  x ).Take(3);

        Console.WriteLine(string.Join(" ", b));





    }
}