using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_events
{
    internal class Exchange
    {
        private List<Currency> currencyPairs = new List<Currency>();
        public void AddCurrencyPair(Currency currencyPair)
        {
            currencyPairs.Add(currencyPair);
        }

        public void StartTrade()
        {
            Random random = new Random();
            foreach (var item in currencyPairs)
            {
                int price = item.Price;
                item.ChangePrice(random.Next(price - 5, price + 5));
            }
        }
    }
}
