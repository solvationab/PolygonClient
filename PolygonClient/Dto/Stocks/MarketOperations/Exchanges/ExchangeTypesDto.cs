using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.MarketOperations.Exchanges
{
    public enum ExchangeTypesDto
    {
        /// <summary>
        /// Represents a traditional exchange.
        /// </summary>
        [JsonPropertyName("exchange")]
        Exchange,

        /// <summary>
        /// Represents a trade reporting facility.
        /// </summary>
        [JsonPropertyName("TRF")]
        Trf,

        /// <summary>
        /// Represents a SIP (Securities Information Processor).
        /// </summary>
        [JsonPropertyName("SIP")]
        Sip,
    }
}