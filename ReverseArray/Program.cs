﻿using System.CodeDom.Compiler;
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

    // Complete the reverseArray function below.
    static void reverseArray(int[] a)
    {
        int[] temp = new int[a.Length];
        for (int i = a.Length - 1; i >= 0; i--)
        {
            Console.Write(a[i]+" ");
        }

    }

    static void Main(string[] args)
    {

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        reverseArray(arr);


    }
}
