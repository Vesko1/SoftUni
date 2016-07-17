using System;
using System.Linq;
using System.Collections.Generic;

class Program
{

    static void Main()
    {

        double[] a = Console.ReadLine().Split().Select(double.Parse).ToArray();


        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();



        for (int i = 0; i < a.Length; i++)
        {

            if ( counts.ContainsKey(a[i]))
            {

                counts[a[i]]++;


            }
            else
            {

                counts.Add(a[i], 1);
            }

        }

        foreach (var item in counts.Keys)
        {

            Console.WriteLine("{0} -> {1}", item, counts[item]);
        }














    }
}