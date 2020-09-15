using System;
namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            PrintPattern.print(n);
        }
        
    }
    public static class PrintPattern
    {
        public static void print(int n)
        {

            for (int i = 0; i < n; i++)
            {
                int k = 1;
                int c = 0;
                int r = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(k);
                    k++;
                    c++;
                }
                for (int z = i + 1; z < n * 2 - c; z++)
                {
                    Console.Write(" ");
                }

                for (int j = n * 2; j > n * 2 - c; j--)
                {
                    Console.Write(r);
                    r++;
                }
                Console.WriteLine();
            }            
        }
    }
}