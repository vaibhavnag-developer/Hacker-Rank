using System;

namespace Time_Conversion
{

    class Program
    {

        /*
         * Complete the timeConversion function below.
         */
        static void timeConversion(string s)
        {

            DateTime t = Convert.ToDateTime(s);
            Console.WriteLine(t.TimeOfDay);


        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            timeConversion(s);


        }
    }

}
