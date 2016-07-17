using System;
using System.Linq;

class Program
{
    static void Main()
    {



        long n = long.Parse(Console.ReadLine());

      
        bool[] e = new bool[n+1];
        for (int i = 2; i < n+1; i++)
        {
            e[i] = true;
        }
        
        for (int j = 2; j < n+1; j++)
        {
            if (e[j])
            {
                for (long p = 2; (p * j) < n+1; p++)
                {
                    e[p * j] = false;
                }
            }
        }

        for (int i = 0; i < e.Length; i++)
        {
            if (e[i] == true)
            {
                Console.WriteLine(i);
            }
         

        }




    }
}
