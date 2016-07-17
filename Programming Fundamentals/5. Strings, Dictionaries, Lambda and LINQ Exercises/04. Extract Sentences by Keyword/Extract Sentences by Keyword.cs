using System;
using System.Collections.Generic;
using System.Linq;

class LAstKNumbers
{

    static void Main(string[] args)
    {

        string separator = Console.ReadLine();

        string[] input = Console.ReadLine().Split('.', '!', '?');

        foreach (var item in input)
        {
            string[] split = item.Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (split.Contains(separator))
            {
                 Console.WriteLine(item);
            }

        }


    }
}