using System.Xml.Linq;

namespace IEnumerableAndLinq
{
    internal class Demo3_func
    {
        public static void Run()
        {
            Action<string> myWrite1 = Write;
            Action<string> myWrite2 = (string x) => { Console.WriteLine(x); };
            Func<string, int, string> greet = (name, exclamationPointCount) => $"Hei, {name}{new string('!', exclamationPointCount)}";
            var greet2 = Greet2;
            var greetingTerje = greet2("Terje", 5);

            var numbers = new int[] { 1, 2, 3 };
            //var numbers = new List<int> { 1, 2, 3 };
            Func<int, int> selector = n => n * 2;
            var doubledNumbers = numbers.Select(selector); // tilsvarer map i JS
        }

        private static string Greet2(string name, int exclamationPointCount)
        {
            return $"Hei, {name}{new string('!', exclamationPointCount)}";
        }

        private static void Write(string name)
        {
            Console.WriteLine(name);
        }
    }
}
