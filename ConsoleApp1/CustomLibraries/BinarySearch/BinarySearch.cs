using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries.BinarySearch
{
    class BinarySearch
    {
        public void binarysearch()
        {

            try
            {
                /*Read the size of the array*/
                int size = Int32.Parse(Console.ReadLine());

                /*get the string array with the inputed array by the user*/
                String[] array = (Console.ReadLine()).Split(' ');

                /*Read the number of queries that are going to be executed*/
                int querySize = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < querySize; i++)
                {
                    /*call the function that is going to deliver his position on the vector*/
                    int low  = 0;
                    int high = size - 1;


                }

            }
            catch (Exception e)
            {

            }
        }

    }
}
