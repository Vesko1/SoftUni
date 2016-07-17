using System;

public class Substring_broken
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            char letter1 = (char)('a' + i);


            for (int q = 0; q < n; q++)
            {
                char letter2 = (char)('a' + q);


                for (int w = 0; w < n; w++)
                {

                    char letter3 = (char)('a' + w);

                    Console.WriteLine("{0}{1}{2}",letter1,letter2,letter3);


                }

            }

        }

    }
}
