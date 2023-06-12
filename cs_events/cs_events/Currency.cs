using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_events
{
    internal class Currency
    {
        public string Name { get; }
        public int Price { get; private set; }
        public event Action<int, bool, Currency> ChangePriceEvent;
        private int numInSeries;
        private int isfallsOrRisesSeries;
        public Currency(string name, int price)
        {
            Name = name;
            Price = price;
            numInSeries = 0;
            isfallsOrRisesSeries = 0;
        }
        public void ChangePrice(int newPrice)
        {
            Console.WriteLine($"Pair {Name}, old price - {Price}, New price - {newPrice}");
            if (isfallsOrRisesSeries == 0)
            {
                numInSeries = 1;
                isfallsOrRisesSeries = newPrice < Price ? -1 : 1;
            }
            else if (newPrice < Price) 
            {
                if (isfallsOrRisesSeries < 0)
                    ++numInSeries;
                else if (0 < isfallsOrRisesSeries) 
                {
                    numInSeries = 1;
                    isfallsOrRisesSeries = -1;
                }

            }
            else if (Price < newPrice)
            {
                if (0 < isfallsOrRisesSeries) 
                    ++numInSeries;          
                else if (isfallsOrRisesSeries < 0) 
                {
                    numInSeries = 1;
                    isfallsOrRisesSeries = 1;
                }
            }

            Price = newPrice;
            if (3 <= numInSeries) 
            {
                numInSeries = 0;
                ChangePriceEvent?.Invoke(Price, (0 < isfallsOrRisesSeries) ? true : false, this);
            }
        }
    }
}
