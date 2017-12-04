using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool checkXRange = x >= x1 && x <= x2;
            bool checkYRange = y >= y1 && y <= y2;

            bool isOnXSides = (x == x1 && checkYRange) || (x == x2 && checkYRange);
            bool isOnYSides = (y == y1 && checkXRange) || (y == y2 && checkXRange);

            if (isOnXSides || isOnYSides)
                Console.WriteLine("Border");
            else
                Console.WriteLine("Inside / Outside");
        }
    }
}
