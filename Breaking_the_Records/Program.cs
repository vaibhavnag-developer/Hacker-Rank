using System;
using System.Collections.Generic;

namespace Breaking_the_Records
{
    class Program
    {
        // Complete the breakingRecords function below.
        static void breakingRecords(int[] scores)
        {
            List<int> maxList = new List<int>();
            List<int> minList = new List<int>();
            int minCount = 0;
            int maxCount = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (i == 0)
                {
                    minList.Add(scores[i]);
                    maxList.Add(scores[i]);
                }
                else
                {
                    if (recordMinValue(scores[i], minList))
                    {
                        minList.Clear();
                        minList.Add(scores[i]);
                        minCount++;
                    }
                    else
                    {
                        if (recordMaxValue(scores[i], maxList))
                        {
                            maxList.Clear();
                            maxList.Add(scores[i]);
                            maxCount++;
                        }

                    }

                }

            }
            Console.WriteLine(maxCount + " " + minCount);
        }
        static bool recordMinValue(int a, List<int> minList)
        {
            foreach (int i in minList)
            {
                if (i > a)
                {
                    return true;
                }
            }
            return false;
        }
        static bool recordMaxValue(int a, List<int> maxList)
        {
            foreach (int i in maxList)
            {
                if (i < a)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            breakingRecords(scores);


        }
    }

}
