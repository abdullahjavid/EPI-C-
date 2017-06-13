using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI4._1
{
    class Program
    {
        static byte[] bits = {0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0};

        static void Main(string[] args)
        {
            var val1 = Convert.ToUInt32("101110110", 2);
            var val2 = Convert.ToUInt32("110100101", 2);
            var val3 = Convert.ToUInt32("101011101011", 2);
            var val4 = Convert.ToUInt32("110100101010011", 2);
            var val5 = Convert.ToUInt32("001001011010", 2);

            Console.WriteLine(CalcParity(val1));    // Parity = 0
            Console.WriteLine(CalcParity(val2));    // Parity = 1
            Console.WriteLine(CalcParity(val3));    // Parity = 0
            Console.WriteLine(CalcParity(val4));    // Parity = 0
            Console.WriteLine(CalcParity(val5));    // Parity = 1
        }

        static byte CalcParity(uint number)
        {
            byte result = 0;
            
            while(number != 0)
            {
                //result ^= (byte)(number & 1);
                //number >>= 1;
                //result ^= 1;
                //number &= number - 1;
                result ^= bits[number & 15];
                number >>= 4;
            }

            return result;
        }
    }
}
