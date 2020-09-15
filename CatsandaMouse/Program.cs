using System;

namespace CatsandaMouse
{
    class Program
    {

        // Complete the catAndMouse function below.
        static void catAndMouse(int x, int y, int z)
        {
            int tmp = Math.Abs(x - z);
            int tmp2 = Math.Abs(y - z);
            if (tmp < tmp2)
            {
                Console.WriteLine("Cat A");
            }
            else if (tmp2 < tmp)
            {
                Console.WriteLine("Cat B");
            }
            else
            {
                Console.WriteLine("Mouse C");
            }

        }

        static void Main(string[] args)
        {


            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                catAndMouse(x, y, z);

            }


        }
    }

}