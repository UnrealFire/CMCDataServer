using System;
namespace CMCDataServer.Models
{
    public class GlobalData
    {
        GlData data;
        GlMetadata metadata;

        public GlData Data { get => data; set => data = value; }
        public GlMetadata Metadata { get => metadata; set => metadata = value; }
    }

    public class GlData
    {
        int active_cryptocurrencies;
        int active_markets;
        double bitcoin_percentage_of_market_cap;

        public int ActiveCryptocurrencies { get => active_cryptocurrencies; set => active_cryptocurrencies = value; }
        public int ActiveMarkets { get => active_markets; set => active_markets = value; }
        public double BitcoinPercentageOfMarketCap { get => bitcoin_percentage_of_market_cap; set => bitcoin_percentage_of_market_cap = value; }
    }

    public class GlQuotes
    {
        GlUSD USD;

        public GlUSD Usd { get => USD; set => USD = value; }
    }

    public class GlUSD
    {
        double total_market_cap;
        double total_volume_24h;

        public double TotalMarketCap { get => total_market_cap; set => total_market_cap = value; }
        public double TotalVolume24h { get => total_volume_24h; set => total_volume_24h = value; }
    }

    public class GlMetadata
    {
        int timestamp;
        string error;

        public int Timestamp { get => timestamp; set => timestamp = value; }
        public string Error { get => error; set => error = value; }
    }
}
