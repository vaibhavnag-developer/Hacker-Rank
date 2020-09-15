using System;
namespace DrawingBook
{
    class Program
    {
        /*
         * Complete the pageCount function below.
         */
        static int pageCount(int n, int p)
        {
            int frontCount = 0;
            int backCount = 0;
            for (var i = 0; i < n; i = i + 2)
            {

                if (i != 1 && i != 0)
                {
                    frontCount++;

                }
                if (p == i || (p == (i + 1)))
                {
                    break;
                }
            }
            if (n % 2 == 0)
            {
                n = n + 1;
            }
            for (var i = n; i > 0; i = i - 2)
            {
                if (i != n && (i != n - 1))
                {
                    backCount++;
                }
                if (p == i || (p == (i - 1)))
                {
                    break;
                }
            }
            if (backCount > frontCount)
            {
                return frontCount;
            }
            return backCount;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            Console.WriteLine(result);
        }
    }

}
