using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.TechnicalIndicators.SimpleMovingAverage
{
    public class SimpleMovingAverageDto
    {
        public SimpleMovingAverageDto(
            SimpleMovingAverageUnderlyingDto underlying, 
            IReadOnlyCollection<SimpleMovingAverageValueDto> values
        )
        {
            Underlying = underlying;
            Values = values;
        }

        [JsonPropertyName("underlying")] 
        public SimpleMovingAverageUnderlyingDto Underlying { get; }

        [JsonPropertyName("values")]
        public IReadOnlyCollection<SimpleMovingAverageValueDto> Values { get; }
    }
}