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

namespace SaveThePriosoner
{
    class Solution
    {

        // Complete the saveThePrisoner function below.
        static int saveThePrisoner(int n, int m, int s)
        {
            //for (int i = 1; i <= m; i++)
            //{
            //    if (s == n)
            //    {
            //        s = 0;
            //    }
            //    if (i!=1)
            //    {
            //        s++;
            //    }                
            //}
            //return s;

            int a = m + s - 1;
            if (a % n == 0)
            {
                return n;
            }
            else
            {
                return a % n;
            }

        }

        static void Main(string[] args)
        {
            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }

        }
    }
}



