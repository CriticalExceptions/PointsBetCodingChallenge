using PointsBetStringFormatterProject.Extensions;

namespace PointsBetStringFormatterProject
{
    public class Program
    {
        public static void Main()
        {
            // setup scenario 1
            var list1 = new List<string>();
            var result1 = list1.ToCommaSeparatedList(true);

            // setup scenario 2
            var list2 = new List<string>
            {
                "test1"
            };
            var result2 = list2.ToCommaSeparatedList(true);

            // setup scenario 3
            var list3 = new List<string>
            {
                "test1",
                "test2",
                "test3"
            };
            var result3 = list3.ToCommaSeparatedList(false);

            Console.WriteLine($"Result1: {result1}");
            Console.WriteLine($"Result2: {result2}");
            Console.WriteLine($"Result3: {result3}");
        }
    }
}
