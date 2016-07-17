using System;
using System.Linq;

class Program
{

    static void Main()
    {

         int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] numbers = new int[65536];


        for (int i = 0; i < array.Length; i++)
        {


            numbers[array[i]]++;




        }

        int bestmatch = 0;
        int index_in_array = 0;
        int number = 0;

        for (int i = 0; i < numbers.Length; i++)
        {

            int checker = numbers[i];
           if (checker > bestmatch)
            {
                bestmatch = checker;
                number= i;
                index_in_array = Array.IndexOf(array, i);
            }

           if (checker == numbers[i])
            {
                int temp = Array.IndexOf(array, i);

                if( temp < index_in_array && bestmatch == checker )
                {
                    number = i;
                }

            }



        }
        Console.WriteLine(number);

    }
}