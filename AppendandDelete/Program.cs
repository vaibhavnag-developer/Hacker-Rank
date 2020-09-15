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
namespace AppendandDelete
{
    class Solution
    {

        // Complete the appendAndDelete function below.
        static string appendAndDelete(string s, string t, int k)
        {
            //int count = Enumerable.Range(0, Math.Min(s.Length, t.Length))
            //     .Count(i =>s[i] == t[i]);
            if (s.Length < t.Length)
            {
                return "No";
            }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(i<t.Length && t.Length > 0)
                {
                    if (s.ElementAt(i) == t.ElementAt(i))
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }

                }

            }

            int tLength = Math.Abs(count - t.Length);
            int sLength = Math.Abs(count - s.Length);


            if ((tLength + sLength) <= k)
            {
                return "Yes";

            }
            else
            {
                return "No";
            }






        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);
            Console.WriteLine(result);
        }
    }
}


