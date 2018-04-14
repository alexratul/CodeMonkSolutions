using System;
using ConsoleApp1.CustomLibraries.LinearSearch;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //new BasicStuff().reversePrintingArray();

            /* Array stuff
            BasicStuff basicStuff = new BasicStuff();

            int[,] result = basicStuff.transposeArray(3, 5, (basicStuff.array2D));

            basicStuff.print2DArray(5, 3, result);
            */

            /*String stuff*/
            //new Strings().sortedSubString();

            /*Linear search*/
            new LinearSearch().lastOcurrence();

            Console.ReadKey();
        }
    }
}
