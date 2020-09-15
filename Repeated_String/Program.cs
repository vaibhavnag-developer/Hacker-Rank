using System;
using System.Linq;
using System.Numerics;
using System.Text;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long count = 0;
        char []ch=s.ToCharArray();
        count = ch.Count(a => a == 'a');
        long factor = n / s.Length;
        long remaonder = n % s.Length;
        count = count * factor;

        for (int i = 0; i < remaonder; i++)
        {
            if (s.ElementAt(i) == 'a')
            {
                count++;
            }
        }
           
        return count;
        
    }

    static void Main(string[] args)
    {

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);
        Console.WriteLine(result);

    }
}
