using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.TechnicalIndicators.SimpleMovingAverage
{
    public class SimpleMovingAverageValueDto
    {
        public SimpleMovingAverageValueDto(long timestamp, decimal value)
        {
            Timestamp = timestamp;
            Value = value;
        }

        /// <summary>
        /// The Unix Msec timestamp from the last aggregate used in this calculation.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; }

        /// <summary>
        /// The indicator value for this period.
        /// </summary>
        [JsonPropertyName("value")]
        public decimal Value { get; }
    }
}