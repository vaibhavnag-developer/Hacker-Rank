﻿using System;

namespace A_Very_Big_Sum
{
    class Program
    {

        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (long number in ar)
            {
                sum = sum + number;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = aVeryBigSum(ar);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}
