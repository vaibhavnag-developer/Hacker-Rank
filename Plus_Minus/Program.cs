using System;

namespace Plus_Minus
{
    class Program
    {

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            int pos_count = 0, neg_count = 0, zero_count = 0;

            foreach (int i in arr)
            {
                if (i > 0)
                {
                    pos_count = pos_count + 1;
                }
                if (i < 0)
                {
                    neg_count = neg_count + 1;
                }
                if (i == 0)
                {
                    zero_count = zero_count + 1;
                }

            }
            int len = arr.Length;
            Console.WriteLine((double)pos_count / len);
            Console.WriteLine((double)neg_count / len);
            Console.WriteLine((double)zero_count / len);

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }

}
