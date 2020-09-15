using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPDFViewer
{
    class Solution
    {

        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            int wordCount = word.Length;

            string[] wordSplit = word.Split();
            byte[] asciiByte = Encoding.ASCII.GetBytes(word);
            List<int> wordHeight = new List<int>();
            foreach (byte i in asciiByte)
            {
                int j = i - 97;
                wordHeight.Add(h[j]);
            }

            int maxValue = wordHeight.Max();

            return wordCount * maxValue;

        }

        static void Main(string[] args)
        {

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }
    }
}
