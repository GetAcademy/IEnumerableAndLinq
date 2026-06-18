using System.Collections;

namespace IEnumerableAndLinq.Demo1
{
    internal class PowerOfTwo : IEnumerable<int>
    {
        private int _max;

        public PowerOfTwo(int max)
        {
            _max = max;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new PowerOfTwoEnumerator(_max);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
