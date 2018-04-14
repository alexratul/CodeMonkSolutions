using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries.LinearSearch
{
    class LinearSearch
    {

        public void lastOcurrence()
        {

            try
            {

                /*Read the first line for the size of the array and the element to be searched*/
                String preintegers = Console.ReadLine();

                /*Separate the strings using split*/
                String[] parameters = preintegers.Split(' ');

                /*Convert them in to integers*/
                int size = Int32.Parse(parameters[0]);
                int elementToSearch = Int32.Parse(parameters[1]);

                /*create a variable for saving the last position*/
                int lastPosition = 1;

                /*Read again the console for the elements inside of the array*/
                String[] array = Console.ReadLine().Split(' ');

                for (int i = 0; i < size; i++)
                {
                    if (Int32.Parse(array[i]) == elementToSearch)
                    {
                        lastPosition = i + 1;
                    }
                }

                Console.WriteLine(lastPosition);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error this exception: " + e + " occured");
            }
        }

    }
}
