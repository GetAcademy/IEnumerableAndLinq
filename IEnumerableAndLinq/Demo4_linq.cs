using IEnumerableAndLinq.Demo1;

namespace IEnumerableAndLinq
{
    internal class Demo4_linq
    {
        public static void Run()
        {
            //var numbers = new int[] { 1, 2, 3 };
            //var numbers = new List<int> { 1, 2, 3 };
            var numbers = new PowerOfTwo(1000);
            var doubledNumbers = numbers.Select(n=>n*2); // tilsvarer map i JS
            var filteredNumber = doubledNumbers.Where(n => n is >= 100 and <= 500); // tilsvarer filter is JS
            Console.WriteLine(string.Join(',', filteredNumber));


            var resultNumbers =
                new PowerOfTwo(1000)
                    .Select(n => n * 2)
                    .Where(n => n is >= 100 and <= 500);
            Console.WriteLine(string.Join(',', resultNumbers));
        }
    }
}
