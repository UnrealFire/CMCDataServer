using System;
namespace CMCDataServer.Models
{
    public class CurrencyDB
    {
        int id;
        string _Name;
        int _Rank;
        double _CirculatingSupply;
        double _TotalSupply;
        double _MaxSupply;

        double _USDPrice;
        double _USDVolume24h;
        double _USDPercentChange1h;
        double _USDPercentChange24h;
        double _USDPercentChange7d;

        double _EURPrice;
        double _EURVolume24h;
        double _EURPercentChange1h;
        double _EURPercentChange24h;
        double _EURPercentChange7d;

        double _RUBPrice;
        double _RUBVolume24h;
        double _RUBPercentChange1h;
        double _RUBPercentChange24h;
        double _RUBPercentChange7d;

        int _LastUpdated;

        public int Id { get => id; set => id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Rank { get => _Rank; set => _Rank = value; }
        public double CirculatingSupply { get => _CirculatingSupply; set => _CirculatingSupply = value; }
        public double TotalSupply { get => _TotalSupply; set => _TotalSupply = value; }
        public double MaxSupply { get => _MaxSupply; set => _MaxSupply = value; }
        public double USDPrice { get => _USDPrice; set => _USDPrice = value; }
        public double USDVolume24h { get => _USDVolume24h; set => _USDVolume24h = value; }
        public double USDPercentChange1h { get => _USDPercentChange1h; set => _USDPercentChange1h = value; }
        public double USDPercentChange24h { get => _USDPercentChange24h; set => _USDPercentChange24h = value; }
        public double USDPercentChange7d { get => _USDPercentChange7d; set => _USDPercentChange7d = value; }
        public double EURPrice { get => _EURPrice; set => _EURPrice = value; }
        public double EURVolume24h { get => _EURVolume24h; set => _EURVolume24h = value; }
        public double EURPercentChange1h { get => _EURPercentChange1h; set => _EURPercentChange1h = value; }
        public double EURPercentChange24h { get => _EURPercentChange24h; set => _EURPercentChange24h = value; }
        public double EURPercentChange7d { get => _EURPercentChange7d; set => _EURPercentChange7d = value; }
        public double RUBPrice { get => _RUBPrice; set => _RUBPrice = value; }
        public double RUBVolume24h { get => _RUBVolume24h; set => _RUBVolume24h = value; }
        public double RUBPercentChange1h { get => _RUBPercentChange1h; set => _RUBPercentChange1h = value; }
        public double RUBPercentChange24h { get => _RUBPercentChange24h; set => _RUBPercentChange24h = value; }
        public double RUBPercentChange7d { get => _RUBPercentChange7d; set => _RUBPercentChange7d = value; }
        public int LastUpdated { get => _LastUpdated; set => _LastUpdated = value; }
    }
}
