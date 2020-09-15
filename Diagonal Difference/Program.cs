using System;
using System.Collections.Generic;
using System.Linq;
namespace Diagonal_Difference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int left_sum = 0;
            int right_sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        left_sum = left_sum + arr[i][j];
                    }
                }

            }
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = arr.Count - 1; j >= 0; j--)
                {
                    if ((i + j) == (arr.Count - 1))
                    {
                        right_sum = right_sum + arr[i][j];
                    }

                }
            }

            return Math.Abs(left_sum - right_sum);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

