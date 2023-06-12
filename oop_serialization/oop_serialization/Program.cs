using System.Runtime.InteropServices;
using System.Text.Json;

namespace oop_serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyFloat> numbers = new List<MyFloat> { };
            int n1, n2;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter two numbers:");
                if (int.TryParse(Console.ReadLine().ToString(), out n1))
                    if (int.TryParse(Console.ReadLine().ToString(), out n2))
                        numbers.Add(new MyFloat(n1, n2));
            }

            Console.WriteLine(string.Join(", ", numbers ?? Enumerable.Empty<MyFloat>()));

            string json = JsonSerializer.Serialize(numbers);
            File.WriteAllText("data.json", json);
            string jsonResult = File.ReadAllText("data.json");
            var peopleResult = JsonSerializer.Deserialize<List<MyFloat>>(jsonResult);

            Console.WriteLine(string.Join(", ", peopleResult ?? Enumerable.Empty<MyFloat>()));
            Console.WriteLine("Finish");

            //Task Magazine

            MagazineManager manager = new MagazineManager();
            Magazine magazine = new Magazine("AAA", "BBB", DateTime.Now, 13);
            magazine.AddArticle(title: "Article1", announcement: "Some text", 15);
            magazine.AddArticle(title: "Article2", announcement: "Some text", 25);
            magazine.AddArticle(title: "Article3", announcement: "Some text", 35);
            manager.AddMagazine(magazine);
            //manager?.DisplayMagazines();


            foreach (var item in manager)
            {
                Console.WriteLine(item);
                foreach (Article item1 in (Magazine)item)
                    Console.WriteLine(item1);
            }
            string file = "data.bin";
            manager.SirializeMagazine(file);
            manager.ClearMagazine();
            manager?.DisplayMagazines();

            Console.WriteLine("After deserialize");
            manager.DeserializeMagazine(file);
            manager?.DisplayMagazines();
            foreach (var item in manager)
            {
                Console.WriteLine(item);
                foreach (Article item1 in (Magazine)item)
                    Console.WriteLine(item1);
            }
        }
    }
}