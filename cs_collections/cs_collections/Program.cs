
using cs_collections;
using System.Collections;

namespace _cs_collections
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            /*
            //create lists
            ArrayList arr = new ArrayList() { 1, 9, 2.2, false, 0, false };
            List<bool> listBool = new List<bool>();
            List<int> listInt = new List<int>();
            List<double> listDouble = new List<double>();
            //sort
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] is bool)
                {
                    listBool.Add((bool)arr[i]);
                }
                if (arr[i] is int)
                {
                    listInt.Add((int)arr[i]);
                }
                if (arr[i] is double)
                {
                    listDouble.Add((double)arr[i]);
                }
            }
            //Show arraylist
            Console.WriteLine("Collection:");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            //show sorted lists
            Console.WriteLine("\nBool:");
            for (int i = 0; i < listBool.Count; i++)
            {
                Console.Write($"{listBool[i]} ");
            }
            Console.WriteLine("\nInt:");
            for (int i = 0; i < listInt.Count; i++)
            {
                Console.Write($"{listInt[i]} ");
            }
            Console.WriteLine("\nDouble:");
            for (int i = 0; i < listDouble.Count; i++)
            {
                Console.Write($"{listDouble[i]} ");
            }
            Console.WriteLine();
            */
            //task2
            /*
            List<string> list = new List<string>() { "hi", "wa", "let", "camboje" };

            string s1 ="";
            string s2 = "";

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Length > list[i - 1].Length)
                {
                    s1 = list[i];
                }
                else
                {
                    s1 = list[i];
                }
                if (list[i].Length == list[i - 1].Length)
                {
                    s1 = list[i];
                    s2 = list[i-1];
                }
            }

            if (String.Compare(s1, s2) < 0)
            {
                Console.WriteLine($"\"{s1}\" - is the biggest");
            }
            else
            {
                Console.WriteLine($"\"{s2}\" - is the biggest");
            }
            */
            //task3
            /*
            PhoneBook phoneBook= new PhoneBook();

            phoneBook.Add();
            phoneBook.Edit();
            phoneBook.Search();
            phoneBook.Delete();
            phoneBook.Search();
            */
            //task 4

            CardDeck deck = new CardDeck();

            deck.ShowDeck();
        }
    }
}