using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int loops = int.Parse(Console.ReadLine());

        int[] EndLoop = new int[arr.Length];
        int[] temp = new int[arr.Length];
        for (int q = 0; q < loops; q++)
        {

            int changed = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                arr[i] = changed;
                changed = first;


            }

            for (int i = 0; i < arr.Length; i++)
            {
                EndLoop[i] = EndLoop[i] + arr[i];
            }

          
 
        }
       
        Console.WriteLine(string.Join(" ", EndLoop));
    }
}
