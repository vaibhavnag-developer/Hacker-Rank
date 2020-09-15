using System;
namespace Divisible_Sum_Pairs
{

    class Solution
    {

        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int K, int[] A)
        {// Create a frequency array to count
         // occurrences of all remainders when 
         // divided by K 
            int[] freq = new int[K];

            // Count occurrences of all remainders 
            for (int i = 0; i < n; i++)
                ++freq[A[i] % K];

            // If both pairs are divisible by 'K' 
            int sum = freq[0] * (freq[0] - 1) / 2;

            // count for all i and (k-i) 
            // freq pairs 
            for (int i = 1; i <= K / 2 && i != (K - i); i++)
                sum += freq[i] * freq[K - i];

            // If K is even 
            if (K % 2 == 0)
                sum += (freq[K / 2] * (freq[K / 2] - 1) / 2);
            return sum;

        }

        static void Main(string[] args)
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);

        }
    }

}
