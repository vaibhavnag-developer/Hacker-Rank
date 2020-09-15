using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingValleys
{
    class Program
    {

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if (++sum == 0)
                        count++;
                }
                else sum--;
            }
            return count;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
        }
    }

}
