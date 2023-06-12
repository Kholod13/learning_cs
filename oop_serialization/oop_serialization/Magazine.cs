using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_serialization
{
    [Serializable]
    internal class Magazine : IEnumerable
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime Date { get; set; }
        public int Pages { get; set; }
        public List<Article> articles { get; set; }
        public Magazine()
        {
            articles = new List<Article>();
        }
        public Magazine(string name, string publisher, DateTime date, int pages)
        {
            Name = name;
            Publisher = publisher;
            Date = date;
            Pages = pages;
            articles = new List<Article>();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Release date: {Date.ToShortDateString()}");
            Console.WriteLine($"Page count: {Pages}");
        }
        public override string ToString()
        {
            return $"{Name} {Date.ToShortDateString()}. Publisher: {Publisher}. {Pages} pages. {articles?.Count} articles";
        }
        public void ShowAllArticles()
        {
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
        }
        public void AddArticle(string title, string announcement, int characterCount)
        {
            articles.Add(new Article(title, announcement, characterCount));
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)articles).GetEnumerator();
        }
    }
}
