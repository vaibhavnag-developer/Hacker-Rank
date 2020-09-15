using System;
namespace Apple_Orange
{

    class Program
    {

        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //List<int> apple_fall_range = new List<int>();
            //List<int> orange_fall_range = new List<int>();
            int count_Apple = 0;
            int count_Orange = 0;
            foreach (int i in apples)
            {

                if ((a + i) >= s && (a + i) <= t)
                {
                    count_Apple++;
                }
                //apple_fall_range.Add(a + i);

            }
            foreach (int i in oranges)
            {
                if ((b + i) >= s && (b + i) <= t)
                {
                    count_Orange++;
                }
                //orange_fall_range.Add(b + i);
            }
            Console.WriteLine(count_Apple);
            Console.WriteLine(count_Orange);

        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }

}
