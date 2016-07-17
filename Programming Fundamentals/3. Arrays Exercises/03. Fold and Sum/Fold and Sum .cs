using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = arr.Length/4;

        int[] temp_arr = new int[k];
        int[] temp_arr1 = new int[k];

        for (int i = 0; i < k; i++)
        {
            temp_arr[i] = arr[i];
        }

        int a = 0;
        for (int i = arr.Length-1; i > arr.Length-k-1; i--)
        {
            temp_arr1[a] = arr[i];
            a++;
        }

        Array.Reverse(temp_arr);
        var first_row = temp_arr.Union(temp_arr1).ToArray();


        int[] second_row = new int[2 * k];
        int b = 0;
        for (int i = 0; i < arr.Length; i++)
        {
    
        if ( i < k  || i >= 3*k)
            {
                continue;
            }
        else
            {
                second_row[b] = arr[i];
                b++;
            }
        }


      var suma =  first_row.Zip(second_row, (x, y) => x + y);
           Console.WriteLine(string.Join(" ", suma));



    }
}
