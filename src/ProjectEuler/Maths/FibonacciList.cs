using System.Collections.Generic;

namespace ProjectEuler.Maths
{
    public class FibonacciList : List<int>
    {
        public FibonacciList(int maxValue)
        {
            var index = 0;
            var value = 0;

            Add(1);
            Add(2);

            while (value < maxValue)
            {
                value = this[index] + this[index + 1];
                Add(value);
                index++;
            }
        }
    }
}