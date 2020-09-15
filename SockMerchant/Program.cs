using System;
using System.Collections.Generic;
using System.Linq;
namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, List<int> ar)
        {
            List<int> l = new List<int>();
            int count = 0;
            foreach (var tmp in ar.GroupBy(i => i))
            {
                l.Add(tmp.Count());

            }
            foreach (var tmp in l)
            {
                int quot = tmp / 2;
                count = count + quot;
            }

            return count;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

        }
    }

}
