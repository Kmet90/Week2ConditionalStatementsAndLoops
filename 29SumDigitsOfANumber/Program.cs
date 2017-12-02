using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29SumDigitsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int newNumber = number;
            do
            {
                int lastDigit = newNumber % 10;
                newNumber = newNumber / 10;
                sum = sum + lastDigit;
            }
            while (newNumber > 0);

            Console.WriteLine(sum);
        }
    }
}
