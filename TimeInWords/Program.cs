using System;

namespace TimeInWords
{
    class Program
    {

        // Complete the timeInWords function below.
        static string timeInWords(int h, int m)
        {
            string hour = "";

            switch (h)
            {
                case 1:
                    hour = "One";
                    break;
                case 2:
                    hour = "Two";
                    break;
                case 3:
                    hour = "Three";
                    break;
                case 4:
                    hour = "Four";
                    break;
                case 5:
                    hour = "Five";
                    break;
                case 6:
                    hour = "Six";
                    break;
                case 7:
                    hour = "Seven";
                    break;
                case 8:
                    hour = "Eight";
                    break;
                case 9:
                    hour = "Nine";
                    break;
                case 10:
                    hour = "Ten";
                    break;
                case 11:
                    hour = "Eleven";
                    break;
                case 12:
                    hour = "Twelve";
                    break;
            }




            return "";

        }

        static void Main(string[] args)
        {

            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);


        }
    }

}
