using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CustomLibraries.BasicNumberTheory
{
    class BasicNumberTheory
    {
        bool checkprime(int N)
        {
            int count = 0;
            for (int i = 1; i * i <= N; ++i)
            {
                if (N % i == 0)
                {
                    if (i * i == N)
                        count++;
                    else       // i < sqrt(N) and (N / i) > sqrt(N)
                        count += 2;
                }
            }
            if (count == 2)
                return true;
            else
                return false;
        }


        public void allprimeNumbers()
        {

            try
            {
                int number = Int32.Parse(Console.ReadLine());
                int primecount = 0;
                for (int i = 1; i < number; i++)
                {
                    bool result = checkprime(i);
                    if (result)
                    {
                        ++primecount;

                    }
                }
                Console.WriteLine(primecount);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }


    }
}
