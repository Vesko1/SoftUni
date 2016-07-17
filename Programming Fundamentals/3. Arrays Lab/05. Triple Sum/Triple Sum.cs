using System;
using System.Linq;

class LAstKNumbers
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();


        int[] array = input.Split(' ').Select(int.Parse).ToArray();

        bool showed = true;

        for (int i = 0; i < array.Length-1; i++)
        {
            int num = 0;
            //int a = 0;
            //int b = 0;
            for (int q = i+1; q < array.Length; q++)
            {

                num = array[i] + array[q];

                if (array.Contains(num))
                {
                    Console.WriteLine("{0} + {1} == {2}", array[i], array[q], num);
                    showed = false;

                }

            }


        }
        if (showed)
        {

            Console.WriteLine("No");
        }


    }
}