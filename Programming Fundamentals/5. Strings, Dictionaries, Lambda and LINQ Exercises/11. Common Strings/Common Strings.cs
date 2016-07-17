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

            char[] a = Console.ReadLine().ToCharArray();
            char[] b = Console.ReadLine().ToCharArray();

            var intersect = a.Intersect(b).ToArray();

            if (intersect.Length > 0)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}