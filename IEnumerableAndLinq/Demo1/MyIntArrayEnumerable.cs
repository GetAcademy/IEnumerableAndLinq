using System.Collections;

namespace IEnumerableAndLinq.Demo1
{
    internal class MyIntArrayEnumerable : IEnumerable<int>
    {
        private readonly int[] _numbers;

        public MyIntArrayEnumerable(params int[] numbers)
        {
            _numbers = numbers;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new MyIntArrayEnumerator(_numbers);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
