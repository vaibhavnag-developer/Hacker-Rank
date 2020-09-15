using System;

namespace Birthday_Chocolate
{
    class Program
    {

        // Complete the birthday function below.
        static int birthday(int[] s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int c = m;
                int sum = 0;
                if ((i + c) > s.Length)
                {
                    break;
                }
                while (c > 0)
                {
                    sum = sum + s[i + c - 1];
                    c--;
                }
                if (sum == d)
                {
                    count++;
                }

            }
            return count;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[] s = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), artemp => Convert.ToInt32(artemp));

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
        }
    }

}
