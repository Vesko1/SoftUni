using System;
using System.Linq;
using System.Collections.Generic;

class Program
{

    static void Main()
    {

        string[] a = Console.ReadLine().ToLower().Split(' ');


       var counts = new Dictionary<string, int>();



        foreach (var item in a)
        {


            if (counts.ContainsKey(item))
            {

                counts[item]++;


            }
            else
            {

                counts.Add(item, 1);
            }

        }

        List<string> values = new List<string>();

        foreach (var item in counts)
        {
            if (item.Value % 2 == 1)
            {
                values.Add(item.Key);
            }
        }
        

        Console.WriteLine(string.Join(", ", values));


    }
}