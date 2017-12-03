﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string tickets = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (tickets == "premiere") price = rows * columns * 12.00;
            else if (tickets == "normal") price = rows * columns * 7.50;
            else if (tickets == "discount") price = rows * columns * 5.00;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
