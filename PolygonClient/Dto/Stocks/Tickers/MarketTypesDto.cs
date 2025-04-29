using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public enum MarketTypesDto
    {
        [EnumMember(Value = "stocks")]
        Stocks,

        [EnumMember(Value = "crypto")]
        Crypto,

        [EnumMember(Value = "fx")]
        Fx,

        [EnumMember(Value = "otc")]
        Otc,

        [EnumMember(Value = "indices")]
        Indices,
    }
}