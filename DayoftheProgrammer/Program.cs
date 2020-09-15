using System;
using System.Collections.Generic;

namespace DayoftheProgrammer
{
    class Program
    {
        static string JulianCalender(int year)
        {
            int date = 13;
            if (year % 4 == 0)
            {
                date =getDateValue(); 
            }
            
            return formatDate(date,year);

        }
        static string GregorianCalender(int year)
        {
            int date = 13;
            if (year % 400 == 0 ||(year%4==0 && year%100!=0))
            {
                date=getDateValue();
            }
            
            return formatDate(date,year);

        }
       static string formatDate(int date,int year)
        {
            return Convert.ToString(date) + "." + "09" + "." + Convert.ToString(year);
        }
        public static int getDateValue()
        {
            int date = 13;
            return --date;
        }
        static string calculateYear1918(int year)
        {            

            return "26.09."+Convert.ToString(year);
        }
        static void Main(string[] args)
        {        
            int year = Convert.ToInt32(Console.ReadLine().Trim());
            string result = "";
            if (year <= 1917)
            {
                result=JulianCalender(year);
            }
            else if(year>=1919)
            {
                result=GregorianCalender(year);
            }
            else if(year==1918)
            {
                result=calculateYear1918(year);
            }
            Console.WriteLine(result);
        }
        
    }
}
