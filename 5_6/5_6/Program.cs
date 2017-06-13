using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] stockPrices = { 310, 315, 275, 295, 260, 270, 290, 230, 255, 250 };

            Console.WriteLine(FindSingleBuySellProfit(stockPrices));
        }

        private static double FindSingleBuySellProfit(double[] stockPrices)
        {
            double minPrice = double.MaxValue;
            double max_profit_so_far = 0;

            for (int i = 0; i < stockPrices.Length; i++)
            {
                max_profit_so_far = Math.Max(max_profit_so_far, stockPrices[i] - minPrice);
                minPrice = Math.Min(stockPrices[i], minPrice);
            }

            return max_profit_so_far;
        }
    }
}
