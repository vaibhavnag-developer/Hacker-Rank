using System;
namespace Staircase
{
    class Program
    {

        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) == n - 1)
                    {
                        Console.Write("#");
                    }
                    else if ((i + j) >= n - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }

}
