using System;

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

                 //Draw(p1.x, p1.y, p1.symb);
                 //Draw(  p2.x, p2.y, p2.symb);







            Console.ReadLine();

            static void Draw(int x, int y, char symb)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symb);
            }













        }
    }
}
