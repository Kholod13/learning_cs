using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_collections
{
    internal class PhoneBook
    {
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();

        public PhoneBook()
        {
            phoneBook.Add("Rescue", 101);
            phoneBook.Add("Police", 102);
            phoneBook.Add("Ambulance", 103);
        }

        public void Add()
        {
            bool inic = false;
            while (inic == false)
            {
                Console.Write("Input name >> ");
                string name = Console.ReadLine();
                Console.Write("Input phone number >> ");
                int num = int.Parse(Console.ReadLine());

                phoneBook.Add(name, num);

                Console.WriteLine("[1] - Continue added contacts?\n" +
                    "[2] - end");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {

                }
                else
                {
                    inic = true;
                }
            }
        }
        public void Search()
        {
            Console.WriteLine("Search with helpful:\n" +
                "[1] - name | [2] - number");
            int i = int.Parse(Console.ReadLine());

            string sName;
            int sNum;
            if(i == 1)
            {
                Console.WriteLine("Input search name >> ");
                sName = Console.ReadLine();

                if (phoneBook.ContainsKey(sName))
                {
                    Console.WriteLine("Contact:\n" +
                    $"Name: {sName}");
                    int value;
                    if (phoneBook.TryGetValue(sName, out value))
                    {
                        Console.WriteLine($"Number: {value}");
                    }
                }
                else
                {
                    Console.WriteLine("PhoneBook is empty");
                }
            }
            else if (i == 2)
            {
                Console.WriteLine("Input search number >> ");
                sNum = int.Parse(Console.ReadLine());

                if (phoneBook.ContainsValue(sNum))
                {
                    Console.WriteLine("Contact:\n");

                    string key = phoneBook.FirstOrDefault(x => x.Value == sNum).Key;
                    if (!string.IsNullOrEmpty(key))
                    {
                        Console.WriteLine($"Name: {key}");
                    }

                    Console.WriteLine($"Numer: {sNum}");
                }
                else
                {
                    Console.WriteLine("PhoneBook is empty");
                }
            }
            else
            {
                Console.WriteLine("Error - incorrect value!");
            }
        }

        public void Edit()
        {
            Console.WriteLine("Input search edit contact with helpful:\n" +
                            "[1] - name | [2] - number");
            int i = int.Parse(Console.ReadLine());

            string sName;
            int sNum;
            if (i == 1)
            {
                Console.WriteLine("Input search name >> ");
                sName = Console.ReadLine();

                if (phoneBook.ContainsKey(sName))
                {
                    Console.Write("Input new name >> ");
                    string newName = Console.ReadLine();
                    Console.Write("Input new number >> ");
                    int newNum = int.Parse(Console.ReadLine());

                    phoneBook.Add(newName, newNum);
                    phoneBook.Remove(sName);
                    
                }
                else
                {
                    Console.WriteLine("PhoneBook is empty");
                }
            }
            else if (i == 2)
            {
                Console.WriteLine("Input search number >> ");
                sNum = int.Parse(Console.ReadLine());

                if (phoneBook.ContainsValue(sNum))
                {
                    Console.Write("Input new name >> ");
                    string newName = Console.ReadLine();
                    Console.Write("Input new number >> ");
                    int newNum = int.Parse(Console.ReadLine());

                    phoneBook.Add(newName, newNum);
                    string key = phoneBook.FirstOrDefault(x => x.Value == sNum).Key;
                    if (!string.IsNullOrEmpty(key))
                    {
                        phoneBook.Remove(key);
                    }
                }
                else
                {
                    Console.WriteLine("PhoneBook is empty");
                }
            }
            else
            {
                Console.WriteLine("Error - incorrect value!");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Input search delete contact with helpful:\n" +
                           "[1] - name | [2] - number");
            int i = int.Parse(Console.ReadLine());

            string sName;
            int sNum;
            if (i == 1)
            {
                Console.WriteLine("Input search name >> ");
                sName = Console.ReadLine();

                if (phoneBook.ContainsKey(sName))
                {
                    phoneBook.Remove(sName);

                }
                else
                {
                    Console.WriteLine("PhoneBook is empty");
                }
            }
            else if (i == 2)
            {
                Console.WriteLine("Input search number >> ");
                sNum = int.Parse(Console.ReadLine());

                if (phoneBook.ContainsValue(sNum))
                {
                    string key = phoneBook.FirstOrDefault(x => x.Value == sNum).Key;
                    if (!string.IsNullOrEmpty(key))
                    {
                        phoneBook.Remove(key);
                    }
                }
                else
                {
                    Console.WriteLine("PhoneBook is empty");
                }
            }
            else
            {
                Console.WriteLine("Error - incorrect value!");
            }
        }
    }
}
