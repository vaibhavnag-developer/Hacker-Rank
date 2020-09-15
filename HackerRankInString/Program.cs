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

namespace HackerRankInString
{
    class Solution
    {

        // Complete the hackerrankInString function below.
        static string hackerrankInString(string s)
        {
            int j = 0;
            string str = "hackerrank";
            if (s.Length<str.Length)
            {
                return "No";
            }
            for (int i = 0; i < s.Length; i++)
            {
                if(j<str.Length && (s.ElementAt(i) == str.ElementAt(j)))
                {
                    j++;
                }
                if (j == str.Length)
                {
                    return "YES";

                }
            }
            //return (j == str.Length ? "YES" : "NO");
            return "NO";
            
        }

        static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);

                Console.WriteLine(result);
            }

        }
    }

}

