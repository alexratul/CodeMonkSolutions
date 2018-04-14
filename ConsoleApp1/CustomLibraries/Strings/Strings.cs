using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries
{
    class Strings
    {
        private string sortedSubString(string s, string StringN, string StringM)
        {
            /*Parsing the integers from the strings inputed*/
            int n = int.Parse(StringN);
            int m = int.Parse(StringM);
            //string result = "empty while i'm making the logic using: " + n +" "+" "+m+" "+s;
            string selectedSubString = s.Substring(n, m);

            /*sorting decently the substring*/
            /**********************************************************/
            /*Change from string to a char array*/
            char[] PreSortedSubtring = selectedSubString.ToCharArray();
            /*Use the array sorting tool on the char array*/
            Array.Sort(PreSortedSubtring);
            /*reverse the sorting to get the decending sorting*/
            Array.Reverse(PreSortedSubtring);
            /***********************************************************/


            /*convert the main string into array of chars*/
            char[] MainString = s.ToCharArray();
            /*Loop in this array and make the changes using the sorted one on the substring*/
            int SubStringIndex = 0;
            for (int i = n; i <= m; i++)
            {
                MainString[i] = PreSortedSubtring[SubStringIndex++];
            }
            
            String result = new string(MainString);
            return result;
        }


        public void sortedSubString()
        {
            int testcases = 0;
            /*Read the console for the first input the number of test cases*/
            try
            {
                testcases = int.Parse(Console.ReadLine());

                if (testcases < 1 || testcases > 1000)
                {
                    Console.WriteLine("Error, the numbers is less than 1 or more than 1000");
                }

                else
                {
                    Console.WriteLine("The number of test cases is: " + testcases);

                    /*This start the loop with the number of times inputed by the user*/
                    for (int i = 0; i < testcases; i++)
                    {
                        String paramaters = Console.ReadLine();
                        Console.WriteLine("This string: " + paramaters + " are going to be process by the fuction");
                        //Split the parameters inside of the string using the function on C#
                        string[] Separatedparameters = paramaters.Split(' ');
                        Console.WriteLine(sortedSubString(Separatedparameters[0],Separatedparameters[1], Separatedparameters[2]));

                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error the line isn't an number");
            }

        }
    }
}
