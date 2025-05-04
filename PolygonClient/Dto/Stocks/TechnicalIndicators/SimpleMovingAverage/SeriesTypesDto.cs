using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks.TechnicalIndicators.SimpleMovingAverage
{
    public enum SeriesTypesDto
    {
        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "high")]
        High,

        [EnumMember(Value = "low")]
        Low,

        [EnumMember(Value = "close")]
        Close,
    }
}
