using System;
using System.Linq;
class Solution
{
    // Complete the findDigits function below.
    static void findDigits(int n)
    {
        string s = Convert.ToString(n);
        int count = 0;
        var numbers = s.Where(w => Char.IsNumber(w)).ToList().Select(temp => (int)Char.GetNumericValue(temp)).ToList();
        foreach (var item in numbers)
        {
            if (item != 0)
            {
                if (n % Convert.ToInt32(item) == 0)
                {
                    count++;
                }
            }

        }

        Console.WriteLine(count);
    }

    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            findDigits(n);

        }

    }
}
