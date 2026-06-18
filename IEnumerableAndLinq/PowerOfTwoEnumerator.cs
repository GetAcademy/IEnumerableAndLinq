using System.Collections;

namespace IEnumerableAndLinq
{
    internal class PowerOfTwoEnumerator : IEnumerator<int>
    {
        private int _nextValue = 1;
        private int _current;
        private readonly int _max;

        public PowerOfTwoEnumerator(int max)
        {
            _max = max;
        }

        public bool MoveNext()
        {
            if (_nextValue > _max) return false;
            _current = _nextValue;
            _nextValue *= 2;
            return true;
        }

        public void Reset()
        {
            _nextValue = 1;
            _current = 0;
        }

        public int CurrentX => _current;
        int IEnumerator<int>.Current => _current;

        object? IEnumerator.Current => _current;

        public void Dispose()
        {
        }
    }
}
