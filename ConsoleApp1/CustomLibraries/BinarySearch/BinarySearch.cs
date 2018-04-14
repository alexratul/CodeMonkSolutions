using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries.BinarySearch
{
    class BinarySearch
    {

        int binarySearch(int low, int high, int key, String[] array)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (Int32.Parse(array[mid]) < key)
                {
                    low = mid + 1;
                }
                else if (Int32.Parse(array[mid]) > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }

            }


            return -1;
        }

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
                    int key = Int32.Parse(Console.ReadLine());

                    int result = binarySearch(low, high, key, array);

                    if (result < 0)
                    {
                        Console.WriteLine("Error key not found");
                    }

                    else
                    {
                        Console.WriteLine(result + 1);
                    }

                }

            }
            catch (Exception e)
            {

            }
        }

    }
}
