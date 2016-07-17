using System;
using System.Linq;

class Program
{

    static void Main()
    {

                char[] arr = Console.ReadLine().ToCharArray();


        foreach (var item in arr)
        {

            Console.WriteLine("{0} -> {1}",item, (int)item - 97);


        }


       
    }
}