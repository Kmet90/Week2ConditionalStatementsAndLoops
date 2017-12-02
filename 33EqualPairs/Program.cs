using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool areAllPairsTheSame = true;
            int previousSum = 0;
            int maxDifference = 0;

            for (int i = 0; i < n; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int sum = first + second;

                if (i != 0)
                {
                    if (sum != previousSum)
                    {
                        int currentDifference = Math.Abs(sum - previousSum);
                        if (currentDifference > maxDifference)
                            maxDifference = currentDifference;
                        areAllPairsTheSame = false;
                    }
                }
                previousSum = sum;
            }
            if (areAllPairsTheSame)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}
