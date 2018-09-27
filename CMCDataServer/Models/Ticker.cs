using System;
namespace CMCDataServer.Models
{
    public class Ticker
    {
        TckrData data;
        TckrMetadata metadata;


        public TckrData Data { get => data; set => data = value; }
        public TckrMetadata Metadata { get => metadata; set => metadata = value; }
    }

    public class TckrData
    {
        int id;
        string name;
        string symbol;
        string website_slug;
        int rank;
        double circulating_supply;
        double total_supply;
        double max_supply;
        TckrQuotes quotes;
        int last_updated;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string WebsiteSlug { get => website_slug; set => website_slug = value; }
        public int Rank { get => rank; set => rank = value; }
        public double CirculatingSupply { get => circulating_supply; set => circulating_supply = value; }
        public double TotalSupply { get => total_supply; set => total_supply = value; }
        public double MaxSupply { get => max_supply; set => max_supply = value; }
        public TckrQuotes Quotes { get => quotes; set => quotes = value; }
        public int LastUpdated { get => last_updated; set => last_updated = value; }
    }

    public class TckrQuotes
    {
        private TckrUSD USD;

        TckrUSD Usd { get => USD; set => USD = value; }
    }

    public class TckrUSD
    {
        double price;
        double volume_24h;
        double market_cup;
        double percent_change_1h;
        double percent_change_24h;
        double percent_change_7d;

        public double Price { get => price; set => price = value; }
        public double Volume24h { get => volume_24h; set => volume_24h = value; }
        public double MarketCap { get => market_cup; set => market_cup = value; }
        public double PercentChange1h { get => percent_change_1h; set => percent_change_1h = value; }
        public double PercentChange24h { get => percent_change_24h; set => percent_change_24h = value; }
        public double PercentChange7d { get => percent_change_7d; set => percent_change_7d = value; }


    }

    public class TckrMetadata
    {
        int timestamp;
        string error;

        public int Timestamp { get => timestamp; set => timestamp = value; }
        public string Error { get => error; set => error = value; }
    }
}
