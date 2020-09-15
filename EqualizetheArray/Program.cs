using System;
using System.Collections.Generic;
using System.Linq;
namespace EqualizetheArray
{
    class Solution
    {
        // Complete the equalizeArray function below.
        static int equalizeArray(List<int> arr)
        {
            int lengthOr = arr.Count;
            var findDuplicate = from temp in arr
                                group temp by temp into g
                                let count = g.Count()
                                orderby count descending
                                select new
                                {
                                    Value = g.Key,
                                    CountNo = g.Count()
                                };
            var a = findDuplicate.Select(x => x.Value).FirstOrDefault();


            var finalList = arr.RemoveAll(x => x != a);



            return lengthOr - arr.Count;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            // int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = equalizeArray(arr);
            Console.WriteLine(result);

        }
    }

}
