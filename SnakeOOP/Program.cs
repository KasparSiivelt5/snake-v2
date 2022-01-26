using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');
            Point p2 = new Point(11, 10, '*');



            int x1 = 11;
            int y1 = 10;


            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);

            foreach(Point point in pointList)
            {
                point.Draw();
            }

            
                 //Draw(p1.x, p1.y, p1.symb);
                 //Draw(  p2.x, p2.y, p2.symb);








            Console.ReadLine();














        }
    }
}
