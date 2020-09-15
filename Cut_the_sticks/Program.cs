using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    // Complete the cutTheSticks function below.
    static void cutTheSticks(List<int> arr)
    {
        while (arr.Count > 0)
        {
            Console.WriteLine(arr.Count());
            var min = arr.Min();

            List<int> tempList = new List<int>();
            tempList = arr.Select(temp => temp - min).ToList();
            arr = new List<int>();
            foreach (var item in tempList)
            {
                if (item > 0)
                {
                    arr.Add(item);
                }
            }

        }
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(a => Convert.ToInt32(a)).ToList();

        cutTheSticks(arr);

    }
}
