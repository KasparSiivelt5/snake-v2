using System;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            char symb = 'a';

            int x1 = 11;
            int y1 = 10;

            Draw(x, y, symb);
            Draw(x1, y1, symb);







            Console.ReadLine();

            static void Draw(int x, int y, char symb)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symb);
            }













        }
    }
}
