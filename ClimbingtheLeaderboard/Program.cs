using System;
using System.Collections.Generic;
using System.Linq;
namespace ClimbingtheLeaderboard
{
    class Program
    {
        // Complete the climbingLeaderboard function below.
        static void climbingLeaderboard(List<int> scores, List<int> alice)
        {

            if (alice.Count == 0 || scores.Count == 0)
            {
                Environment.Exit(0);
            }
            bool flag = false;
            foreach (var i in alice)
            {
                int count = 0;
                foreach (var j in scores.GroupBy(j => j))
                {
                    count++;
                    if (i >= j.Key)
                    {
                        flag = true;
                        Console.WriteLine(count);
                        break;
                    }


                }
                if (flag == false)
                {
                    Console.WriteLine(count + 1);
                }

            }


        }

        static void Main(string[] args)
        {

            int scoresCount = Convert.ToInt32(Console.ReadLine());

            List<int> scores = Console.ReadLine().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            int aliceCount = Convert.ToInt32(Console.ReadLine());

            List<int> alice = Console.ReadLine().Split(' ').ToList().Select(aliceTemp => Convert.ToInt32(aliceTemp)).ToList();

            climbingLeaderboard(scores, alice);


        }
    }

}
