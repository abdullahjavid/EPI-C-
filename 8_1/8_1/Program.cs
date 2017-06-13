using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> firstList = new LinkedList<int>(new int[] { 2, 5, 7 });
            LinkedList<int> secondList = new LinkedList<int>(new int[] { 3, 11 });

            PrintLinkedList(firstList);
            PrintLinkedList(secondList);
            PrintLinkedList(MergeSortedLists(firstList, secondList));
        }

        private static LinkedList<int> MergeSortedLists(LinkedList<int> firstList, LinkedList<int> secondList)
        {
            var toReturn = new LinkedList<int>();
            var firstIter = firstList.First;
            var secondIter = secondList.First;

            while (firstIter != null && secondIter != null)
            {
                toReturn.AddLast(Math.Min(firstIter.Value, secondIter.Value));

                if (firstIter.Value <= secondIter.Value)
                    firstIter = firstIter.Next;
                else
                    secondIter = secondIter.Next;
            }

            while (firstIter != null)
            {
                toReturn.AddLast(firstIter.Value);
                firstIter = firstIter.Next;
            }

            while (secondIter != null)
            {
                toReturn.AddLast(secondIter.Value);
                secondIter = secondIter.Next;
            }

            return toReturn;
        }

        private static void PrintLinkedList(LinkedList<int> list)
        {
            var node = list.First;

            while (node != null)
            {
                Console.Write($"{node.Value} ");
                node = node.Next;
            }

            Console.WriteLine();
        }
    }
}
