using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.TechnicalIndicators.SimpleMovingAverage
{
    public class SimpleMovingAverageUnderlyingDto
    {
        public SimpleMovingAverageUnderlyingDto(
            IReadOnlyCollection<SimpleMovingAverageUnderlyingAggregateDto> aggregates,
            string url
        )
        {
            Aggregates = aggregates;
            Url = url;
        }

        [JsonPropertyName("aggregates")]
        public IReadOnlyCollection<SimpleMovingAverageUnderlyingAggregateDto> Aggregates { get; }

        /// <summary>
        /// The URL which can be used to request the underlying aggregates used in this request.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; }
    }
}