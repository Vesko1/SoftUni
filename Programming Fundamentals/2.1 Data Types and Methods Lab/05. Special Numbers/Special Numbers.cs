using System;

public class Substring_broken
{
    public static void Main()
    {


        int input = int.Parse(Console.ReadLine());




        int number = 1;
        bool checker = false;

        for (int i = 0; i < input; i++)
        {
            int temp = number.ToString().Length;
            int Sum = 0;
            int temp_number = number;
            checker = false;
            for (int q = 0; q < temp; q++)
            {

                Sum += temp_number % 10;
                temp_number = temp_number / 10;

            }
             

            if ( Sum == 5 || Sum == 7 || Sum == 11)
            {

                checker = true;
            }


            Console.WriteLine("{0} -> {1}", number, checker);
            number++;
        }

    }
}
