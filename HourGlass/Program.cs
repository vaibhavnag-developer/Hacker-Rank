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

class Solution
{

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        //int finalSum = -63;
        List<int> finalSum = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int sum = 0;
                if (i<arr.Length-2 && j < arr.Length - 2)
                {
                    sum = sum + arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    sum = sum + arr[i + 1][j + 1];
                    sum = sum + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                }
                if (sum == 0)
                {
                    finalSum.Add(-63);
                }
                else
                {
                    finalSum.Add(sum);
                }
                //if (sum > finalSum)
                //{
                //    finalSum = sum;
                //}
                
            }
        }
        //finalSum.RemoveAll(a => a == 0);
        return finalSum.Max();
        //return finalSum;

    }

    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int result = hourglassSum(arr);
        Console.WriteLine(result);
    }
}
