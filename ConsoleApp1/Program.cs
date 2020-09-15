using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void main()
        {
            int x1=0,  y1=0, x2=5,  y2=3;
            string keyMoved= "Queen";
            if (keyMoved == "Queen")
            {
                queen quee = new queen();
                quee.move( x1,  y1,  x2,  y2);
            }
            if (keyMoved == "horse")
            {
                horse hor = new horse();
                hor.move(move);
            }
           
        }

       


    }
}
