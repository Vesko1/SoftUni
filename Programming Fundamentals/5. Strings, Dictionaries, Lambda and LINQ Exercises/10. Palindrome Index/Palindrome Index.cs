using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Reverse_the
{
    class Program
    {

        static bool IsPalindrome(string text)
        {

            return text.SequenceEqual(text.Reverse());

        }

        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            int remove = 0;


            if (text.SequenceEqual(text.Reverse()))
            {

                Console.WriteLine(-1);
            }       
            else
            {

                for (int i = 0; i < text.Length; i++)
                {
                  if (IsPalindrome(text.Remove(i, 1)))
                        {
                   
                        remove = i;
                         }
                }
 Console.WriteLine(remove);

     
            }
       
           


        }
    }
}