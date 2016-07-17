using System;
using System.Linq;

class Program
{

    public static char[] Trim(char[] str)
    {
        return str.Where(x => !Char.IsWhiteSpace(x)).ToArray();
    }

    static void Main()
    {
        char[] arr1 = Console.ReadLine().ToCharArray();

        char[] arr2 = Console.ReadLine().ToCharArray();

        int len1 = arr1.Length;
        int len2 = arr2.Length;

        int min = Math.Min(len1, len2);

        int ToPrint = 0;
        for (int i = 0; i < min; i++)
        {

            if ((char)arr1[i] == (char)arr2[i])
            {
                continue;
            }
            if ((char)arr1[i] < (char)arr2[i])
            {
                ToPrint = 1;

            }
            else
            {
                ToPrint = 2;
            }
        }

        if (ToPrint == 0)
        {
            if (len1 > len2)
            {

                Console.WriteLine(Trim(arr2));
                Console.WriteLine(Trim(arr1));

            }
            else
            {
                Console.WriteLine(Trim(arr1));
                Console.WriteLine(Trim(arr2));
            }


        }
        if (ToPrint == 2)
        {
            Console.WriteLine(Trim(arr2));
            Console.WriteLine(Trim(arr1));


        }

        if (ToPrint == 1)
        {
            Console.WriteLine(Trim(arr1));
            Console.WriteLine(Trim(arr2));


        }

       

    }
}
