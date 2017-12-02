using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0.0;

            if (town == "sofia") 
            {
                if (product == "coffee") sum = quantity * 0.50;
                if (product == "water") sum = quantity * 0.80;
                if (product == "beer") sum = quantity * 1.20;
                if (product == "sweets") sum = quantity * 1.45;
                if (product == "peanuts") sum = quantity * 1.60;
            }

            if (town == "plovdiv")
            {
                if (product == "coffee") sum = quantity * 0.40;
                if (product == "water") sum = quantity * 0.70;
                if (product == "beer") sum = quantity * 1.15;
                if (product == "sweets") sum = quantity * 1.30;
                if (product == "peanuts") sum = quantity * 1.50;
            }

            if (town == "varna")
            {
                if (product == "coffee") sum = quantity * 0.45;
                if (product == "water") sum = quantity * 0.70;
                if (product == "beer") sum = quantity * 1.10;
                if (product == "sweets") sum = quantity * 1.35;
                if (product == "peanuts") sum = quantity * 1.55;
            }
            Console.WriteLine(sum);
        }
    }
}
