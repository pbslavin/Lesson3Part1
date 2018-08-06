using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadingAndTasks
{
    public class Fibonacci
    {
        private int _position;
        public static List<int> cache = new List<int>();
        public Fibonacci(int position)
        {
            _position = position;
        }
        public int Calculate()
        {
            int current = 1;
            int last = 0;
            int temp;

            if (_position == 1)
            {
                cache.Add(current);
                return 0;
            }
            else
            {
                for (int i = 0; i < _position - 2; i++)
                {
                    temp = current;
                    current += last;
                    last = temp;
                }
            }
            cache.Add(current);
            return current;
        }
    }
}
