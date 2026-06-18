using IEnumerableAndLinq.Demo1;

namespace IEnumerableAndLinq
{
    internal class Demo1_foreach
    {
        public static void Run()
        {
            //var numbers = new int[] { 1, 2, 3 };
            //var numbers = new List<int> { 1, 2, 3 };
            bool b = true;
            string s = "Terje";
            Person p = new Person { FirstName = "Terje" };
            var powerOfTwo = new PowerOfTwo(1000);
            var numbers = new MyIntArrayEnumerable(1, 2, 3);

            foreach (var value in numbers)
            {
                Console.WriteLine(value);
            }

            //var enumerator = new PowerOfTwoEnumerator(1000);
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.CurrentX);
            //}
            }
    }

    class Person
    {
        public string FirstName { get; set; }
    }
}
