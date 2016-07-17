using System;
using System.Linq;

class LAstKNumbers
{
    static void Main(string[] args)
    {



        var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();



        var max = Math.Max(arr1.Length, arr2.Length);

        int[] Sum = new int[max];


        for (int i = 0; i < max; i++)
        {

            Sum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];


        }




        Console.WriteLine(string.Join((" "), Sum));






    }
}