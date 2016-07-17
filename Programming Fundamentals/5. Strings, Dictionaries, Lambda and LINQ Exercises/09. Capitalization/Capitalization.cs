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
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                char[] elements = input[i].ToCharArray();

                elements[0] = char.ToUpper(elements[0]);

                input[i] = new string(elements);
            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}