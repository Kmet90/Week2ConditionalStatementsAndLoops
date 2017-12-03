using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int number = j + i;

                    if (number > n)
                    {
                        number = 2 * n - number;
                    }
                    Console.Write(number +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
