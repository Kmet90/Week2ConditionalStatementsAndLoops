using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int newMin = min + 15;

            if (newMin > 59)
            {
                hour = hour + 1;
                if(hour==24)
                {
                    hour = 0;
                }
                newMin = newMin - 60;
                if (newMin < 10)
                {
                Console.WriteLine("{0}:0{1}", hour, newMin);

                }
                else
                    Console.WriteLine("{0}:{1}", hour, newMin);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, newMin);
            }
        }
    }
}
