using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonusScore = 0.0;
            double totalScore = 0.0;

            if (score <= 100) bonusScore = 5;
            else if (score > 100 && score <= 1000) bonusScore = score * 0.20;
            else if (score > 1000) bonusScore = score * 0.10;

            if (score % 2 == 0) bonusScore = bonusScore + 1;
            else if (score % 10 == 5) bonusScore = bonusScore + 2;

            totalScore = bonusScore + score;

            Console.WriteLine(bonusScore);
            Console.WriteLine(totalScore);
        }

    }
}
