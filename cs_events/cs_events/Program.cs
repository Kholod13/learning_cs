using System.Diagnostics;

namespace cs_events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange();
            Trader Tom = new Trader("Tom");
            Trader Grar = new Trader("Grar");
            Trader Lin = new Trader("Lin");
            Currency USD_UAH = new Currency("USD_UAH", 38);
            USD_UAH.ChangePriceEvent += Tom.Trade;
            USD_UAH.ChangePriceEvent += Lin.Trade;
            Currency EUR_UAH = new Currency("EUR_UAH", 41);
            EUR_UAH.ChangePriceEvent += Grar.Trade;
            EUR_UAH.ChangePriceEvent += Lin.Trade;
            Currency CAD_UAH = new Currency("CAD_UAH", 31);
            EUR_UAH.ChangePriceEvent += Grar.Trade;
            EUR_UAH.ChangePriceEvent += Tom.Trade;
            exchange.AddCurrencyPair(USD_UAH);
            exchange.AddCurrencyPair(EUR_UAH);
            exchange.AddCurrencyPair(CAD_UAH);
            for (int i = 0; i < 15; i++)
            {
                exchange.StartTrade();

            }
        }
    }
}