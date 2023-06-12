namespace cs_linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] arr_i = { 1, 23, 42, -53, 0, -2, 7, -6, -13, 1, -54, 30 };
            Console.WriteLine($"Task 1 all positive numbers: {string.Join(", ", arr_i.Where(x => 0 < x).OrderBy(x => x).ToArray())}");
            //Task 2
            var newArr = arr_i.Where(x => 0 < x && x / 100 == 0 && x / 10 != 0);
            Console.WriteLine($"Task 2 count of positive (2 digit): {newArr.Count()}\n" +
                $"average: {newArr.Average()}");
            //Task 3
            int[] years = { 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999 };
            Console.WriteLine($"Task 3 years: " +
                $"{string.Join(", ", years.Where(year => year % 4 == 0 && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))).OrderByDescending(x => x).ToArray())}");
            //Task 4
            Console.WriteLine($"Task 4 Max even number: {arr_i.Where(x => x % 2 == 0).Max()}");
            //Task 5
            string[] arr_s = { "string", "int", "double", "float" };
            Console.WriteLine($"Task 5 string array with !!!: {string.Join(", ", arr_s.Select(x => x + "!!!"))}");
            //Task 6
            char c = 'i';
            Console.WriteLine($"Task 6 strings with a specific character \"{c}\": {string.Join(", ", arr_s.Where(x => x.Contains(c)).ToArray())}");
            //Task 7
            Console.WriteLine($"Task 7 Group by count:");
            arr_s.GroupBy(s => s.Length).OrderBy(group => group.Key).ToList().ForEach(group =>
            {
                Console.WriteLine("Group key: {0}", group.Key);
                group.ToList().ForEach(str => Console.WriteLine(str));
            });
        }
    }
}