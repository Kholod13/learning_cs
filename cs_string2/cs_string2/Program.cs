using Microsoft.VisualBasic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace _cs_string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            /*
            Console.Write("Input >> ");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');

            Array.Reverse(words);

            Console.Write("Reverse: ");

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            */
            //task2
            /*
            string text = Console.ReadLine();
            int firstDotIndex = text.IndexOf('.');
            if (firstDotIndex != -1)
            {
                int secondDotIndex = text.IndexOf('.', firstDotIndex + 1);
                if (secondDotIndex != -1) 
                {
                    string res = text.Substring(firstDotIndex + 1, secondDotIndex - firstDotIndex - 1); 
                    Console.WriteLine(res); 
                }
                else
                {
                    Console.WriteLine("Haven't second dot.");
                }
            }
            else
            {
                Console.WriteLine("Haven't first dot.");
            }
            */
            //task3
            /*
            Console.WriteLine("Input your palindrom >> ");
            string pal = Console.ReadLine();
            bool res = true;

            for (int i = 0; i < pal.Length/2; i++)
            {
                if (pal[i] != pal[pal.Length - i-1])
                {
                    res = false;
                }
            }

            if (res == true)
            {
                Console.WriteLine("Your number is palindrom!");
            }
            else
            {
                Console.WriteLine("Your number is not palindrom!");
            }
            */
            //task4
            /*
            Console.Write("Input your text >> ");
            string text = Console.ReadLine();

            int c1 = 0, c2 = 0, c = 0;
            foreach(char i in text)
            {
                if (Char.IsUpper(i))
                {
                    c1++;
                }
                if (Char.IsLower(i))
                {
                    c2++;
                }
                c++;
            }

            double smallLetters = (double)c2 / c * 100;
            double bigLetters = (double)c1 / c * 100;

            Console.WriteLine($"Small % letters: {smallLetters}");
            Console.WriteLine($"Big % letters: {bigLetters}");
            */
            //task5
            /*
            Console.Write("Input string >> ");
            string str = Console.ReadLine();

            string[] words = str.Split(" ");

            Console.Write("Input number word >> ");
            int num = int.Parse(Console.ReadLine());
            num--;

            string res = words[num];
            Console.WriteLine($"First letter your word >> {res[0]}");
            */
            //task6
            /*
            Console.Write("Input string >> ");
            string str = Console.ReadLine();

            string[] words = str.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Length > 5)
                {
                    words[i] = words[i].Substring(0, words[i].Length - 3) + "$$$";
                }
            }

            Console.WriteLine($"Array: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            */
            //task7
            /*
            Console.Write("Input str>> ");
            string str = Console.ReadLine();

            string pattern = @"\b[A-Z]{2,}\b";
            
            MatchCollection matches = Regex.Matches(str, pattern);

            Console.WriteLine("Abreviaturs:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            */
        }
    }
}
