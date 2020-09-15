using System;
class Solution
{
    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        //while (d > 0)
        //{
            int []res=RotateArrayLef(a,n,d);
            //a = res;
            //d--;
        //}
        for (int i = 0; i < res.Length; i++)
        {
            Console.Write(res[i] + " ");
        }
    }
    public static int[] RotateArrayLef(int [] a,int n, int d)
    {
        int[] res= new int [a.Length];
        //int k = 0;
        for (int i = 0; i < a.Length; i++)
        {
            //if (k== 0)
            //{
            //    res[a.Length - 1] = a[i];
            //}
            //else
            //{
            //    res[k - 1] = a[i];
            //}
            //k++;
            res[(i + n - d) % n] = a[i];
        }
        return res;
    }
}
