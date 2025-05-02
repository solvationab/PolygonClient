using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers.TickerTypes
{
    public enum AssetClassesDto
    {
        [EnumMember(Value = "stocks")]
        Stocks,

        [EnumMember(Value = "options")]
        Options,

        [EnumMember(Value = "crypto")]
        Crypto,

        [EnumMember(Value = "fx")]
        Fx,

        [EnumMember(Value = "indices")]
        Indices,
    }
}