using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double tempValue = 0;

            if (input == "m") tempValue = distance;
            else if (input == "mm") tempValue = distance / 1000;
            else if (input == "cm") tempValue = distance / 100;
            else if (input == "mi") tempValue = distance / 0.000621371192;
            else if (input == "in") tempValue = distance / 39.3700787;
            else if (input == "km") tempValue = distance / 0.001;
            else if (input == "ft") tempValue = distance / 3.2808399;
            else if (input == "yd") tempValue = distance / 1.0936133;

            if (output == "m") tempValue *= 1;
            else if (output == "mm") tempValue *= 1000;
            else if (output == "cm") tempValue *= 100;
            else if (output == "mi") tempValue *= 0.000621371192;
            else if (output == "in") tempValue *= 39.3700787;
            else if (output == "km") tempValue *= 0.001;
            else if (output == "ft") tempValue *= 3.2808399;
            else if (output == "yd") tempValue *= 1.0936133;

            Console.WriteLine($"{tempValue} {output}");

        }
    }
}
