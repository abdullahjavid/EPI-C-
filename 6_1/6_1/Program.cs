using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrToInt("4321"));
            Console.WriteLine(StrToInt("0"));
            Console.WriteLine(StrToInt("-0"));
            Console.WriteLine(StrToInt("-153"));

            Console.WriteLine(IntToStr(4321));
            Console.WriteLine(IntToStr(0));
            Console.WriteLine(IntToStr(-0));
            Console.WriteLine(IntToStr(-153));
        }

        private static int StrToInt(string str)
        {
            int result = 0;

            for (int i = str[0] == '-' ? 1 : 0; i < str.Length; i++)
            {
                result = result * 10 + str[i] - '0';
            }

            return str[0] == '-' ? -result : result;
        }

        private static string IntToStr(int intVal)
        {
            bool isNegative = false;

            if (intVal < 0)
                isNegative = true;

            string str = "";

            do
            {
                str = (char)('0' + Math.Abs(intVal % 10)) + str;
                intVal /= 10;
            }
            while (intVal != 0);

            return isNegative ? "-" + str : str;
        }
    }
}