using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_Array_With_difference_1
{
    class Result
    {

        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int pickingNumbers(List<int> a)
        {
            int count = 0;
            List<int> result = new List<int>();
            foreach (var i in a)
            {
                foreach (var j in a)
                {
                    if (a.First() == j)
                    {
                        continue;
                    }
                    if (Math.Abs(i - j) <= 1)
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                    if (result.Count > 0)
                    {

                    }

                }
            }

            return count;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);
            Console.WriteLine(result);
        }
    }

}
