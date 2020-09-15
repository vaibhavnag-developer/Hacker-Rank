using System;
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
namespace BeautifulDaysattheMovies
{
    class Solution
    {

        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int z = i; z <= j; z++)
            {
                int n = z;
                int revserse = 0;
                while (n != 0)
                {
                    int remainder = n % 10;
                    revserse = revserse * 10 + remainder;
                    n = n / 10;

                }
                double difference = Math.Abs(revserse - z);
                difference = difference / k;
                if (difference % 1 == 0)
                {
                    count++;
                }

            }
            return count;
        }

        static void Main(string[] args)
        {

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);


        }
    }



}
