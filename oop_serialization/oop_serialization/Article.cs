using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_serialization
{
    [Serializable]
    internal class Article
    {
        public string Title { get; set; }
        public string Announcement { get; set; }
        public int CharacterCount { get; set; }
        public Article(string title, string announcement, int characterCount)
        {
            Title = title;
            Announcement = announcement;
            CharacterCount = characterCount;
        }
        public override string ToString()
        {
            return $"{Title} {Announcement} {CharacterCount} characters";
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Character count: {CharacterCount}");
            Console.WriteLine($"Announcement: {Announcement}");
        }
    }
}
