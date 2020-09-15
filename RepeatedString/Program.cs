using System;
using System.IO;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        char[] ch = s.ToCharArray();
        return 0;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
