using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    // Complete the viralAdvertising function below.
    static void viralAdvertising(int n)
    {
        List<int> cummulativeLiked = new List<int>();
        int shared = 5;
        int liked = 0;
        while (n != 0)
        {
            liked = Math.Abs(shared / 2);
            shared = liked * 3;
            cummulativeLiked.Add(liked);
            n--;
        }
        var sum = cummulativeLiked.Sum();

        Console.WriteLine(sum);
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        viralAdvertising(n);

    }
}
