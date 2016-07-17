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
            int[] input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

            var start = new DateTime(input[2], input[1], input[0]);
            var end = new DateTime(input2[2], input2[1], input2[0]);



            int wd = 0;

            for (DateTime i = start; i <= end; i = i.AddDays(1))
                
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !(i.Month == 1 && i.Day == 1) && !(i.Month == 3 && i.Day == 3) && !(i.Month == 5 && i.Day == 1) && !(i.Month == 5 && i.Day == 6) && !(i.Month == 5 && i.Day == 24) && !(i.Month == 9 && i.Day == 6) && !(i.Month == 9 && i.Day == 22) && !(i.Month == 11 && i.Day == 1) && !(i.Month == 12 && i.Day == 24) && !(i.Month == 12 && i.Day == 25) && !(i.Month == 12 && i.Day == 26))
                {
                    wd++;
                }



            }


            Console.WriteLine(wd);

        }


    }
}