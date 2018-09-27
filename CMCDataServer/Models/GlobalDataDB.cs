using System;
namespace CMCDataServer.Models
{
    public class GlobalDataDB
    {
        int _ActiveCryptoCurrencies;
        int _AllCryptoCurrencies;
        int _ActiveMarkets;
        double _BitcoinPercentageOfMarketCup;

        double _USDTotalMarketCup;
        double _USDVolume24h;

        double _EURTotalMarketCup;
        double _EURVolume24h;

        double _RUBTotalMarketCup;
        double _RUBVolume24h;

        int _LastUpdated;

        public int ActiveCryptoCurrencies { get => _ActiveCryptoCurrencies; set => _ActiveCryptoCurrencies = value; }
        public int ActiveMarkets { get => _ActiveMarkets; set => _ActiveMarkets = value; }
        public double BitcoinPercentageOfMarketCup { get => _BitcoinPercentageOfMarketCup; set => _BitcoinPercentageOfMarketCup = value; }
        public double USDTotalMarketCup { get => _USDTotalMarketCup; set => _USDTotalMarketCup = value; }
        public double USDVolume24h { get => _USDVolume24h; set => _USDVolume24h = value; }
        public double EURTotalMarketCup { get => _EURTotalMarketCup; set => _EURTotalMarketCup = value; }
        public double EURVolume24h { get => _EURVolume24h; set => _EURVolume24h = value; }
        public double RUBTotalMarketCup { get => _RUBTotalMarketCup; set => _RUBTotalMarketCup = value; }
        public double RUBVolume24h { get => _RUBVolume24h; set => _RUBVolume24h = value; }
        public int LastUpdated { get => _LastUpdated; set => _LastUpdated = value; }
        public int AllCryptoCurrencies { get => _AllCryptoCurrencies; set => _AllCryptoCurrencies = value; }
    }
}
