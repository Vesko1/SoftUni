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

            //"C# is not C++, and PHP is not Delphi!";
            char[] separators = new char[] { '.', ',', ';', ':', '=', ')', '(', '&', '[', ']', '\'', '"', '\\', '/', '?', '!',' ' };

            string input = Console.ReadLine();


            string[] cleanstrings = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            char[] cleanstrings_char = string.Join("", cleanstrings).ToCharArray();

            string[] cleanchars = input.Split(cleanstrings_char, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(cleanstrings);

            for (int i = 0; i < cleanstrings.Length; i++)
            {
                Console.Write(cleanstrings[i] + cleanchars[i]);

            }



        }
    }
// }