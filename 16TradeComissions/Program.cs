using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = -1.0;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500) comission = sales * 0.05;
                else if (sales > 500 && sales <= 1000) comission = sales * 0.07;
                else if (sales > 1000 && sales <= 10000) comission = sales * 0.08;
                else if (sales > 10000) comission = sales * 0.12;

            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500) comission = sales * 0.045;
                else if (sales > 500 && sales <= 1000) comission = sales * 0.075;
                else if (sales > 1000 && sales <= 10000) comission = sales * 0.1;
                else if (sales > 10000) comission = sales * 0.13;
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) comission = sales * 0.055;
                else if (sales > 500 && sales <= 1000) comission = sales * 0.08;
                else if (sales > 1000 && sales <= 10000) comission = sales * 0.12;
                else if (sales > 10000) comission = sales * 0.145;
            }

            if (comission < 0)
                Console.WriteLine("error");
            else
                Console.WriteLine($"{comission:f2}");
        }
    }
}
