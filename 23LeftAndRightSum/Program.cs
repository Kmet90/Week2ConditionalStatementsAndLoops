using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int righrSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                righrSum += currentNumber;
            }
            if (leftSum == righrSum)
                Console.WriteLine("Yes, sum = {0}", leftSum);
            else
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - righrSum));
        }
    }
}
