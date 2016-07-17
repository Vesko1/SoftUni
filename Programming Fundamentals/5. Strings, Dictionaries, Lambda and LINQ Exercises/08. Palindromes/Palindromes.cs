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

         
            char[] separators = new char[] { ' ', ',', '.', '?', '!' };

            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

            List<string> result = new List<string>();


            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                char[] array = input[i].ToCharArray();
                Array.Reverse(array);
                string temp = new string(array);
                if (current == temp)
                {
                    result.Add(current);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}