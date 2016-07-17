using System;
using System.Linq;

class Program
{




    static void Main()
    {

        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


        int SecondElement;
        int FirstElement;

        int Matches = 1;
        int BestMatch = 0;

        int position = 0;
        int bestposition = 0;


        for (int i = 0; i < array.Length - 1; i++)
        {

            FirstElement = array[i];
            SecondElement = array[i + 1];


            if (FirstElement == SecondElement)
            {

                Matches++;

                if (Matches > BestMatch)
                {


                    BestMatch = Matches;
                    position = i;
                    bestposition = position;

                }
           }
            else
            {
                Matches = 1;
                position = 0;

            }
        }




        for (int i = 0; i < BestMatch; i++)
        {
            Console.Write("{0} ", array[bestposition]);
        }




    }
}
