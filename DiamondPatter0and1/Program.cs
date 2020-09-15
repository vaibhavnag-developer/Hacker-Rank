using System;

namespace DiamondPatter0and1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[testcases];
            for (int i = 0; i < testcases; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int temp in arr)
            {
                printParrtern(temp);
            }

        }
        public static void printParrtern(int number)
        {
            int i, j, count = 1;
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                #region Printing Space
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                #endregion
                if (j == number)
                {
                    for (int k = 1; k <= 2 * j - 1; k++)
                    {
                        Console.Write("1");
                    }

                    continue;
                }

                for (i = 1; i <= 2 * j - 1; i++)
                {
                    if (i == 1)
                    {
                        Console.Write("1");
                        continue;
                    }
                    if (j < i)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    //Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
