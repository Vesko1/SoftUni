using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class ThreeBrothers
{



    static void Main()

    {

        decimal NummberToBeAdded = decimal.Parse(Console.ReadLine());

        string[] matrix_info = Console.ReadLine().Split(' ');

        int rows = int.Parse(matrix_info[0]);
        int cols = int.Parse(matrix_info[1]);

        decimal[,] matrix = new decimal[rows, cols];



        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            decimal[] temp = Array.ConvertAll(Console.ReadLine().Split(), decimal.Parse);

            for (int q = 0; q < matrix.GetLength(1); q++)
            {



                matrix[i, q] = temp[q];

            }

        }

        int[] index = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int rows_to_change = index[0];
        int cols_to_change = index[1];




        // Sub-Matrix adding the number 


        int rows_start = rows_to_change - 1;
        int rows_end = rows_start + 3;


        if (rows_start < 0)
        {

            rows_start = 0;
        }

        
        if (rows_end > rows)
        {
            rows_end = rows;
        }



        // Cols

        int cols_start = cols_to_change - 1;
        int cols_end = cols_start + 3;

        if (cols_start < 0)
        {
            cols_start = 0;
        }


        if (cols_end > cols)
        {

            cols_end = cols;
        }






        for (int i = rows_start; i < rows_end; i++)
        {
            for (int q = cols_start; q < cols_end; q++)
            {

                matrix[i, q] = matrix[i, q] + NummberToBeAdded;

            }
        }






        for (int i = 0; i < matrix.GetLength(0); i++)
        {


            for (int q = 0; q < matrix.GetLength(1); q++)
            {
                Console.Write("{0} ", matrix[i, q]);

            }
            Console.WriteLine();
        }










    }


}