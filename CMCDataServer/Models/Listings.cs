using System;
namespace CMCDataServer.Models
{
    public class Listings
    {
        LData data;
        LMetadata metadata;

        public LData Data { get => data; set => data = value; }
        public LMetadata Metadata { get => metadata; set => metadata = value; }
    }

    public class LData
    {
        int id;
        string name;
        string symbol;
        string website_slug;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Website_slug { get => website_slug; set => website_slug = value; }
    }

    public class LMetadata
    {
        int timestamp;
        int num_cryptocurrencies;
        string error;

        public int Timestamp { get => timestamp; set => timestamp = value; }
        public int Num_cryptocurrencies { get => num_cryptocurrencies; set => num_cryptocurrencies = value; }
        public string Error { get => error; set => error = value; }
    }
}

