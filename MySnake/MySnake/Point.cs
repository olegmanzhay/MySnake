using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        /// <summary>
        /// Рисует символ в определенной позиции с координатами x,y
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="symbol">Символ</param>
        public void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
