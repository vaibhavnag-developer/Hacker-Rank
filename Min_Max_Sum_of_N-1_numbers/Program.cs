using System;
using System.Collections.Generic;
using System.Linq;
namespace Min_Max_Sum_of_N_1_numbers
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(long[] arr)
        {

            List<long> minmax = new List<long>();

            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (count < arr.Length)
                        {
                            sum = sum + arr[j];
                            count++;
                        }
                    }
                }
                minmax.Add(sum);
            }
            Console.WriteLine(minmax.Min() + " " + minmax.Max());

        }

        static void Main(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);
        }
    }

}
