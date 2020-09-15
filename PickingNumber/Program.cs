using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Largest_Array_With_difference_1
{
    class Result
    {

        public static int pickingNumbers(List<int> a)
        {
            int count = 1;

            List<int> arrCount = new List<int>();
            a.Sort();
           // var temp = from t in a orderby t ascending select t;
            int finalCount = 0;
            int j = 0;
            while (j < a.Count())
            {
                int temp = a[j];
                count = 0;
                for (int i = 0; i < a.Count(); i++)
                {
                    if (i != a.Count() - 1)
                    {
                        if (Math.Abs(temp - a[i]) <= 1)
                        {
                            count++;
                        }

                    }

                }
                if (finalCount <= count)
                {
                    finalCount = count;
                }
                j++;
            }


            return finalCount;
        }
        //static bool SubArray(List<int> l)
        //{
        //    for (int i = 0; i < l.Count(); i++)
        //    {
        //        for (int j = 1; j < l.Count(); j++)
        //        {
        //            if (Math.Abs(l[i] - l[j]) > 1)
        //            {
        //                return false;

        //            }
        //        }
        //    }
        //    return true; ;
        //}
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);

            Console.WriteLine(result);
        }
    }

}
