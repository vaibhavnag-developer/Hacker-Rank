using System;
using System.Collections.Generic;
using System.Linq;

namespace BonAppétit
{
    class Program
    {

        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int sum = 0;
            foreach (var i in bill)
            {
                sum = sum + i;
            }
            int avg = sum / 2;

            int charged = avg - b;

            if (charged == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(Math.Abs(charged));
            }
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }
}

