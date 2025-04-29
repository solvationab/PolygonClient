using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public enum TickerLocalesDto
    {
        [EnumMember(Value = "us")]
        Us,

        [EnumMember(Value = "global")]
        Global,
    }
}