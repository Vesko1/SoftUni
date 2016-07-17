using System;
using System.Linq;
using System.Collections.Generic;

class Program
{

    static void Main()
    {

        //      int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string v = ".,:;()[]\"'!? ";
        string[] a = Console.ReadLine().ToLower().Split(v.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        var b = a.Where(x => x.Length < 5).OrderBy(x => x).Distinct();


        Console.WriteLine(string.Join(", ", b));


    }
}