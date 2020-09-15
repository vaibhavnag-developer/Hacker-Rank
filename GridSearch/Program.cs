using System;

namespace GridSearch
{
    class Solution
    {
        static string gridSearch(int[,] G, int[,] P, int R, int C, int r, int c)
        {

            for (int i = 0; i < R; i++)
            {
                if (i <= R - r)
                {
                    for (int j = 0; j < C; j++)
                    {
                        int[,] square = new int[r, c];
                        int iCounter = i;
                        //int jcounter = j;
                        if (j <= C - c)
                        {
                            for (int e = 0; e < r; e++)
                            {
                                int jcounter = j;
                                for (int d = 0; d < c; d++)
                                {
                                    square[e, d] = G[iCounter, jcounter];
                                    jcounter++;
                                }
                                iCounter++;
                            }
                            if (checkMatching(square, P, r, c))
                            {
                                return "YES";
                            }
                        }

                    }
                }

            }
            return "NO";

        }
        static bool checkMatching(int[,] character, int[,] P, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (character[i, j] == P[i, j])
                    {
                        continue;
                    }
                    else return false;
                }

            }
            return true;
        }


        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] RC = Console.ReadLine().Split(' ');

                int R = Convert.ToInt32(RC[0]);

                int C = Convert.ToInt32(RC[1]);

                int[,] G = new int[R, C];

                for (int i = 0; i < R; i++)
                {
                    char[] GItem = Console.ReadLine().ToCharArray();
                    for (int j = 0; j < C; j++)
                    {
                        //string GItem = Convert.ToString(Console.ReadLine());

                        G[i, j] = Convert.ToInt32(GItem.GetValue(j));
                    }
                }

                string[] rc = Console.ReadLine().Split(' ');

                int r = Convert.ToInt32(rc[0]);

                int c = Convert.ToInt32(rc[1]);

                int[,] P = new int[r, c];

                for (int i = 0; i < r; i++)
                {
                    char[] PItem = Console.ReadLine().ToCharArray();
                    for (int j = 0; j < c; j++)
                    {

                        P[i, j] = Convert.ToInt32(PItem.GetValue(j));
                    }

                }

                string result = gridSearch(G, P, R, C, r, c);

                Console.WriteLine(result);
            }
        }
    }

}
