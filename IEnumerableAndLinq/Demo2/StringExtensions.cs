namespace IEnumerableAndLinq.Demo2
{
    internal static class StringExtensions
    {
        public static bool IsLongerThan(this string s, int length)
        {
            return s.Length > length;
        }
    }
}
