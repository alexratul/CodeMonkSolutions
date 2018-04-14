using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries
{
    class BasicStuff
    {
        /*example array for practice*/
        int[] numberlist = { 1, 2, 3, 4, 5 };

        public int [,] array2D = {{5, 12, 17, 9, 3}, {13, 4, 8, 14, 1}, {9, 6, 3, 7, 21}};

        public void reversePrintingArray()
        {
            for (int i = (numberlist.Length - 1); i > -1; i--)
            {
                Console.WriteLine(numberlist[i]);
            }
        }


        /*Transverse function on a 2d array*/
        public int[,] transposeArray(int rows, int columns, int[,] array)
        {
            /*create this new array*/
            int[,] result = new int[columns,rows];

            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    result[c,r] = array2D[r,c];
                }
            }

            return result;
        }

        public void print2DArray(int rows, int columns, int[,] array)
        {

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(array[r, c]);
                    Console.Write(",");
                }
                Console.WriteLine("");
            }

        }



    }
}
