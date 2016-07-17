using System;
using System.Linq;
using System.Collections.Generic;

using System.Globalization;

namespace _06.Reverse_the
{


    public class Sale
    {



    }


    class Points
    {


        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };


            string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] Author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna”", "Ruse" };


            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {



                int r1 = rnd.Next(0, Phrases.Length);
                int r2 = rnd.Next(0, Events.Length);
                int r3 = rnd.Next(0, Author.Length);
                int r4 = rnd.Next(0, Cities.Length);



                Console.WriteLine("{0}, {1}, {2} - {3} ", Phrases[r1], Events[r2], Author[r3], Cities[4]);
               
            }
        


        }


    }
}