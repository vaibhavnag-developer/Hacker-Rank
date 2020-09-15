using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.Replace(" ", "");
            funEncyption(s);
            
        }
        private static void funEncyption(string s)
        {
            int rows = calculateRowsAndColums(s, out int column);
            char[,] s1= new char[rows, column];
            
            int k = 0;
            string encrypted = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (k <= s.Length-1)
                    {
                        s1[i, j] = s.ElementAt(k);

                        k++;
                    }
                }
            }
            int z = 0;
            while (z < column)
            {

                for (int i = 0; i < rows; i++)
                {
                    if (s1[i, z] != '\0')
                    {
                        encrypted += s1[i, z];
                    }
                    

                }
                z++;
                encrypted += " " ;
                
            }

            Console.WriteLine(encrypted);
        }
        private static int calculateRowsAndColums(string s, out int column)
        {
            double length = s.Length;
            length = Math.Round(Math.Sqrt(length));
            //string convertedLength = Convert.ToString(length);

            //List<string> rowColumn = convertedLength.Split('.').ToList();
            int row = Convert.ToInt32(length);
            column = 1;
           while (!(row*column >= s.Length))
            {
                column++;
            }

            return row;
        }
    }
}
