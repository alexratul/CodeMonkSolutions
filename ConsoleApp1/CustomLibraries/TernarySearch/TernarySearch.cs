using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries.TernarySearch
{
    class TernarySearch
    {
        public void findingMimo()
        {
            try
            {
                /*get the number of intervals*/
                int intervalNumber = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < intervalNumber; i++)
                {
                    /*get the ranges of the intervals*/
                    String[] intervalsRanges = Console.ReadLine().Split(' ');

                    /*Parse the string into ints for the intervals*/
                    int l = Int32.Parse(intervalsRanges[0]);

                    int r = Int32.Parse(intervalsRanges[1]);

                    /*call the mino calculation method*/
                    int result = findMimo(l, r);

                    /*Print the result into the console*/
                    Console.WriteLine(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error this exception: " + e);
            }


        }

        int intPowerOperation(int baseNumber, int exp)
        {
            int result = 1;

            if (exp == 0)
            {
                return result;
            }

            else if (exp == 1)
            {
                return baseNumber;
            }

            else
            {

                for (int i = 1; i <= exp; i++)
                {
                    result = result * baseNumber;
                }
            }
            return result;

        }


        private int findMimo(int l, int r)
        {
            int result = -1;

            for (int i = l; i <= r; i++)
            {
                int functionresult = (2 * (intPowerOperation(i,2))) - (12 * i) + 7;

                if (functionresult >= l && functionresult <= r)
                {
                    result = functionresult;
                }

            }
            return result;
           
        }
    }
}
