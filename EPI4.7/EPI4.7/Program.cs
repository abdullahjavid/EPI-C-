using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(power(5, 26));       // 1490116119384765625
            Console.WriteLine(power(350, 7));      // 643392968750000000
            Console.WriteLine(power(-34, 13));     // -81138303245565435904
            Console.WriteLine(power(324, -3));     // 2.9401194111858136651105202647142e-8
        }
        
        static double power(double x, int y)
        {
            double result = 1.0;

            if (y < 0)
            {
                y *= -1;
                x = 1 / x;
            }

            while (y != 0)
            {
                if (y % 2 != 0)
                    result *= x;

                y /= 2;
                x *= x;
            }

            return result;
        }
    }
}