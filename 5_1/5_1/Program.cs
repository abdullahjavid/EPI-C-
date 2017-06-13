using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new int[] { 0, 1, 2, 0, 2, 1, 1 };

            Partition(testArray, 1);

            Console.WriteLine(string.Join(",", testArray));
        }

        private static void Partition(int[] pArray, int pintPivotIndex)
        {
            int pivot = pArray[pintPivotIndex];

            int smaller = 0, equal = 0, larger = pArray.Length;

            while (equal < larger)
            {
                if (pArray[equal] < pivot)
                    Swap(ref pArray[smaller++], ref pArray[equal++]);
                else if (pArray[equal] == pivot)
                    equal++;
                else
                    Swap(ref pArray[equal], ref pArray[--larger]);
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            v1 ^= v2;
            v2 ^= v1;
            v1 ^= v2;
        }
    }
}