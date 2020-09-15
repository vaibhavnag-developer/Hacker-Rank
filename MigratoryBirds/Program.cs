using System;
using System.Collections.Generic;
using System.Linq;
namespace MigratoryBirds
{
    class Program
    {

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            List<List<int>> l = new List<List<int>>();
            List<int> key = new List<int>();
            List<int> count = new List<int>();

            int highest = 0;

            foreach (var grp in arr.GroupBy(i => i))
            {
                //l.Add(new List<int> { grp.Key, grp.Count() });
                key.Add(grp.Key);
                count.Add(grp.Count());

            }
            highest = count.Max();
            int keyIndex = count.IndexOf(highest);
            int keyvalue = key.ElementAt(keyIndex);


            return keyvalue;
        }

        static void Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }
    }

}
