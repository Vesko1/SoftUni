using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();




            var Average = input.Average();


            var result = input.Where(x => x > Average).OrderByDescending(x => x).Take(5).ToArray();


         

            if (result.Length > 0)
            {


                Console.WriteLine(string.Join(" ", result));
            }

            else
            {
                Console.WriteLine("No");
            }



        }
    }
}
