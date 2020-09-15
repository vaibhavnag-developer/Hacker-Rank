using System;
using System.Linq;
namespace Angry_Professor
{
    class Solution
    {

        // Complete the angryProfessor function below.
        static void angryProfessor(int k, int[] a)
        {
            Console.WriteLine(a.Where(i => i <= 0).Count() < k ? "YES" : "NO");

        }

        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                angryProfessor(k, a);


            }

        }
    }

}
