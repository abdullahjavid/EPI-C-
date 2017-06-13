using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(2);
            stack.Push(2);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(5);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(0);
            stack.Push(3);
        }
    }

    class Stack<T> : System.Collections.Generic.Stack<T> where T : IComparable
    {
        public class MaxInfo
        {
            public MaxInfo(T max, int c)
            { maxVal = max; count = c; }

            public T maxVal;
            public int count;

            public override string ToString()
            {
                return $"{maxVal},{count}";
            }
        }

        public System.Collections.Generic.Stack<MaxInfo> maxValues = new System.Collections.Generic.Stack<MaxInfo>();

        public new void Push(T obj)
        {
            if (maxValues.Count == 0 || maxValues.Peek().maxVal.CompareTo(obj) < 0)
            {
                maxValues.Push(new MaxInfo(obj, 1));
            }
            else if (maxValues.Peek().maxVal.CompareTo(obj) == 0)
            {
                maxValues.Peek().count += 1;
            }

            base.Push(obj);
        }

        public new T Pop()
        {
            T popped = base.Pop();

            var maxVal = maxValues.Peek();

            if (maxVal.maxVal.CompareTo(popped) == 0)
            {
                if (maxVal.count > 1)
                    maxVal.count--;
                else
                    maxValues.Pop();
            }

            return popped;
        }

        public T Max()
        {
            if (maxValues.Count == 0)
                throw new InvalidOperationException("Stack empty");

            return maxValues.Peek().maxVal;
        }
    }
}