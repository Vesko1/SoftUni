using System;
using System.Globalization;
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

              int[] input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

            var result = new DateTime(input[2], input[1], input[0]);
          
              Console.WriteLine(result.DayOfWeek);

          
          
         }
    }
}