using System;
using System.Collections.Generic;
using System.Linq;
namespace SequenceEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());

            //int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
            List<int>arr = Console.ReadLine().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

            Sqeuence(arr);
        }
        static void Sqeuence(List<int> p)
        {
            int k = 0;
            while (k<p.Count())
            {
                findIndex(p, k+1);
                k++;   
            }
        }
        static void findIndex(List<int> p, int item)
        {
            int i = p.IndexOf(item);
            int j = p.IndexOf(i+1);
            Console.WriteLine(j+1);

        }
    }
}
