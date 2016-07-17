using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class ThreeBrothers
{
    static void Main()

   {

       int n = int.Parse(Console.ReadLine());

       string[] list = new string[n];

       int[] houses = new int[4];

       for (int i = 0; i < n; i++)
       {
           list[i] = Console.ReadLine();
       }


       for (int i = 0; i < list.Length; i++)
       {
           int SumOfName = 0;
           char First = list[i][0];
           char Second = ' ';
           for (int q = 0; q < list[i].Length; q++)
           {

               if (list[i][q] == ' ')
               {
                   Second = list[i][q + 1];

               }

               if ((int)list[i][q] > 64)
               {
                   SumOfName = SumOfName + (int)list[i][q];
               }
            }

           if (SumOfName % 4 == 0)
           {
               houses[0]++;
               Console.WriteLine("Gryffindor {0}{1}{2}", SumOfName, First, Second);
           }
           else if (SumOfName % 4 == 1)
           {
               houses[1]++;
               Console.WriteLine("Slytherin {0}{1}{2}", SumOfName, First, Second);

           }
           else if (SumOfName % 4 == 2)
           {
               houses[2]++;
               Console.WriteLine("Ravenclaw {0}{1}{2}", SumOfName, First, Second);

           }
           else if (SumOfName % 4 == 3)
           {
               houses[3]++;
               Console.WriteLine("Hufflepuff {0}{1}{2}", SumOfName, First, Second);

           }

       }
       Console.WriteLine();

       for (int i = 0; i < 4; i++)
       {
           if (i == 0)
           {

               Console.WriteLine("Gryffindor: {0}", houses[i]);
           }
           if (i == 1)
           {

               Console.WriteLine("Slytherin: {0}", houses[i]);
           }
           if (i == 2)
           {

               Console.WriteLine("Ravenclaw: {0}", houses[i]);
           }
           if (i == 3)
           {

               Console.WriteLine("Hufflepuff: {0}", houses[i]);
           }

       }



    }

    
}