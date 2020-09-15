using System;

class Solution
{
    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        String returndate = Convert.ToString(d1) + "/" + Convert.ToString(m1) + "/" + Convert.ToString(y1);
        string duedate = Convert.ToString(d2) + "/" + Convert.ToString(m2) + "/" + Convert.ToString(y2);
        if (Convert.ToDateTime(returndate) <= Convert.ToDateTime(duedate))
        {
            return 0;
        }
        if (y1 - y2 > 0)
        {
            return 10000;
        }
        if (Math.Abs(m1 - m2) > 0)
        {
            return 500 * Math.Abs(m1 - m2);
        }
        else
        {
            return 15 * Math.Abs(d1 - d2);
        }
    }

    static void Main(string[] args)
    {

        string[] d1M1Y1 = Console.ReadLine().Split(' ');

        int d1 = Convert.ToInt32(d1M1Y1[0]);

        int m1 = Convert.ToInt32(d1M1Y1[1]);

        int y1 = Convert.ToInt32(d1M1Y1[2]);

        string[] d2M2Y2 = Console.ReadLine().Split(' ');

        int d2 = Convert.ToInt32(d2M2Y2[0]);

        int m2 = Convert.ToInt32(d2M2Y2[1]);

        int y2 = Convert.ToInt32(d2M2Y2[2]);

        int result = libraryFine(d1, m1, y1, d2, m2, y2);
        Console.WriteLine(result);
    }
}
