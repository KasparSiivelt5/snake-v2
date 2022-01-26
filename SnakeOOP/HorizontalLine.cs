using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class HorizontalLine
    {


        List<Point> pointList;

        public HorizontalLine()
        {
            pointList = new List<Point>();
            Point p1 = new Point(6, 6, '#');
            Point p2 = new Point(7, 6 , '#');
            Point p3 = new Point(8, 6, '#');

            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
        }
    
    
    
    }
}
