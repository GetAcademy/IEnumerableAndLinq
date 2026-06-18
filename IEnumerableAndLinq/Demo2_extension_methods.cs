using IEnumerableAndLinq.Demo2;

namespace IEnumerableAndLinq
{
    internal class Demo2_extension_methods
    {
        public static void Run()
        {
            //var isLongerThan = StringExtensions.IsLongerThan("Terje", 3);
            var isLongerThan = "Terje".IsLongerThan(3);
            Console.WriteLine(isLongerThan ? "Ja" : "Nei");
        }


    }
}
