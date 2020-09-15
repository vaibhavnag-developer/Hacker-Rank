using System;
using System.Linq;
namespace TheHurdleRace
{
    class Program
    {
        // Complete the hurdleRace function below.
        static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();
            int a = max - k;

            if (a > 0)
            {
                return a;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));

            int result = hurdleRace(k, height);

            Console.Write(result);
        }
    }

}
