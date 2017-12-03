using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int number = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write($"{number} ");
                    number++;
                    if (number > n)
                        return;
                }
                counter++;
                Console.WriteLine();
                    
            }
        }
    }
}
