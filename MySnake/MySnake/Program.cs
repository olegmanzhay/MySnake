using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw(p1.x, p1.y, p1.symbol);     // Инкапсуляция - сокрытие данных

            Point p2 = new Point(4, 5, '#');
            p1.Draw(p2.x, p2.y, p2.symbol);     // Инкапсуляция - сокрытие данных

            Console.ReadLine();
        }
    }
}
