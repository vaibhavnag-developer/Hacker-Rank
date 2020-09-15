using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Result
    {

        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> finalGrades = new List<int>();
            foreach (int i in grades)
            {
                if (i < 38)
                {
                    finalGrades.Add(i);
                }
                else
                {
                    int j = i / 5;

                    int z = j * 5 + 5;
                    if ((z - i) < 3)
                    {
                        finalGrades.Add(z);
                    }
                    else
                    {
                        finalGrades.Add(i);
                    }

                }
            }

            return finalGrades;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.GradingStudents(grades);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }

}
