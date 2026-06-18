using System.Collections;

namespace IEnumerableAndLinq.Demo1
{
    internal class MyIntArrayEnumerator : IEnumerator<int>
    {
        private int[] _numbers;
        private int _index = -1;

        public MyIntArrayEnumerator(int[] numbers)
        {
            _numbers = numbers;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _numbers.Length;
        }

        public void Reset()
        {
            _index = -1;
        }

        int IEnumerator<int>.Current => _numbers[_index];

        object? IEnumerator.Current => _numbers[_index];

        public void Dispose()
        {
        }
    }
}
