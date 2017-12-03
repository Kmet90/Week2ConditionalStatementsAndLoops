using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.NumbersFrom2_0to2_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            Console.WriteLine(num);
            for (int i = 0; i < n; i++)
            {
                num = num * 2;
                Console.WriteLine(num);
            }
        }
    }
}
