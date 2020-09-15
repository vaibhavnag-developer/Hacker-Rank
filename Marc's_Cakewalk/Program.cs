using System;
namespace Marc_s_Cakewalk
{
    class Solution
    {
        // Complete the marcsCakewalk function below.
        static double marcsCakewalk(int[] calorie)
        {
            double k = 0;
            double sum = 0;
            for (int i = calorie.Length; i > 0; i--)
            {
                sum = sum + Math.Pow(2, k) * calorie[i - 1];
                k++;

            }

            return sum;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp));
            Array.Sort(calorie);
            double result = marcsCakewalk(calorie);

            Console.WriteLine(result);
        }
    }

}
