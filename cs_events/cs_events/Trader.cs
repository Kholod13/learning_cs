using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_events
{
    internal class Trader
    {
        public string Name { get; }
        private string fileName => Name + ".txt";
        public Trader(string name)
        {
            Name = name;
            using (StreamWriter sw = File.CreateText(fileName)) { }
        }
        public void Trade(int price, bool sellOrNo, Currency pair)
        {
            string message = $"{Name} sees that the price has " +
                (sellOrNo == true ? "risen" : "fallen") +
                $" on {pair.Name}, so he " +
                (sellOrNo == true ? " sells" : " buys") +
                $" his assets by price {price}$\n";
            File.AppendAllText(fileName, message);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
