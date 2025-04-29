using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public enum TickerOrderTypesDto
    {
        [EnumMember(Value = "asc")]
        Asc,

        [EnumMember(Value = "desc")]
        Desc,
    }
}