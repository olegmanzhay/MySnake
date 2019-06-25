using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="symbol">Символ</param>
        static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symbol1 = '*';
            Draw(x1, y1, symbol1);

            int x2 = 4;
            int y2 = 5;
            char symbol2 = '*';
            Draw(x2, y2, symbol2);

            Console.ReadLine();
        }
    }
}
