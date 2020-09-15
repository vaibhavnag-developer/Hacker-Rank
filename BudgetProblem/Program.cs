using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetProblem
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int a = keyboards.Min();
            int c = drives.Min();
            if ((a + c) > b)
            {
                return -1;
            }
            List<int> list = new List<int>();
            foreach (var i in keyboards)
            {
                foreach (int j in drives)
                {
                    if ((i + j) <= b)
                    {
                        list.Add(i + j);
                    }
                }
            }


            return list.Max();
        }

        static void Main(string[] args)
        {

            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(moneySpent);

        }
    }

}
