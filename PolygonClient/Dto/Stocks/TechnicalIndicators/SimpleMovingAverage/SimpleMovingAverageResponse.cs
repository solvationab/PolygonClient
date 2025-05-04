using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.TechnicalIndicators.SimpleMovingAverage
{
    public class SimpleMovingAverageResponse : Response<SimpleMovingAverageDto>
    {
        public SimpleMovingAverageResponse(
            string requestId, 
            string status, 
            string message, 
            SimpleMovingAverageDto results, 
            string nextUrl
            ) : base(requestId, status, message, results)
        {
            NextUrl = nextUrl;
        }

        [JsonPropertyName("next_url")]
        public string NextUrl { get; }
    }
}
