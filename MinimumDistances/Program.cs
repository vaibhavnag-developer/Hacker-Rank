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

namespace MinimumDistances
{   
    class Solution
    {

        // Complete the minimumDistances function below.
        static int minimumDistances(int[] a)
        {
            List<int> index = new List<int>();
            for(int i=0; i < a.Length; i++)
            {

                for(int j = i+1;j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        index.Add(j - i);
                    }
                }

            }

            if (index.Count <= 0) return -1;

            return index.Min();
                     

        }

        static void Main(string[] args)
        {
 
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int result = minimumDistances(a);
            Console.WriteLine(result);
            
         }
    }

}
