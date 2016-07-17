using System;
using System.Linq;

class LAstKNumbers
{
    static void Main(string[] args)
    {

        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (array.Length == 1)
        {
            Console.WriteLine(array[0]);
        }
        else
        {
            while (array.Length != 1)
            {
                int[] array2 = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {

                    int result = array[i] + array[i + 1];

                    array2[i] = result;

                }


                array = array2;

            }
            Console.WriteLine(array[0]);
        }
       
    }
}