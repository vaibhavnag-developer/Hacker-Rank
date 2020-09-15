using System;
using System.Collections.Generic;
using System.Linq;
namespace tallest_candle_blow_problem
{
    class Program
    {

        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            List<int> list = new List<int>();
            int count = 0;

            int result = ar.Max();
            foreach (int i in ar)
            {
                if (result == i)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);

        }
    }

}
