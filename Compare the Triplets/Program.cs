using System;
using System.Collections.Generic;
using System.Linq;

namespace Compare_the_Triplets
{
    class Program
    {

        // Complete the compareTriplets function below.
        private static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> c = new List<int>(2) { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {

                    c[0] = c[0] + 1;
                }
                else if (a[i] < b[i])
                {
                    c[1] = c[1] + 1;
                }
            }
            return c;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);
            foreach (object o in result)
            {
                Console.Write(Convert.ToString(o) + " ");
            }



            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}
