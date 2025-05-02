using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers.RelatedTickers
{
    public class RelatedTickerDto
    {
        public RelatedTickerDto(string ticker)
        {
            Ticker = ticker;
        }

        /// <summary>
        /// The ticker symbol of the related company.
        /// </summary>
        [JsonPropertyName("ticker")]
        public string Ticker { get; }
    }
}
