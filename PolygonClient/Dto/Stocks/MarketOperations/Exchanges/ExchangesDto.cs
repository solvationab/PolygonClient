using PolygonClient.Dto.Stocks.Tickers;
using System.Text.Json.Serialization;
using PolygonClient.Dto.Stocks.Tickers.TickerTypes;

namespace PolygonClient.Dto.Stocks.MarketOperations.Exchanges
{
    public class ExchangesDto
    {
        public ExchangesDto(
            string acronym,
            AssetClassesDto assetClass,
            int id,
            TickerLocalesDto locale,
            string marketIdentifierCode,
            string name,
            string operatingMarketIdentifierCode,
            string participantId,
            ExchangeTypesDto type,
            string url
            )
        {
            Acronym = acronym;
            AssetClass = assetClass;
            Id = id;
            Locale = locale;
            MarketIdentifierCode = marketIdentifierCode;
            Name = name;
            OperatingMarketIdentifierCode = operatingMarketIdentifierCode;
            ParticipantId = participantId;
            Type = type;
            Url = url;
        }

        /// <summary>
        /// A commonly used abbreviation for this exchange.
        /// </summary>
        [JsonPropertyName("acronym")]
        public string Acronym { get; }

        /// <summary>
        /// An identifier for a group of similar financial instruments.
        /// </summary>
        [JsonPropertyName("asset_class")]
        public AssetClassesDto AssetClass { get; }

        /// <summary>
        /// A unique identifier used by Polygon.io for this exchange.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// An identifier for a geographical location.
        /// </summary>
        [JsonPropertyName("locale")]
        public TickerLocalesDto Locale { get; }

        /// <summary>
        /// The Market Identifier Code of this exchange (see ISO 10383).
        /// </summary>
        [JsonPropertyName("mic")]
        public string MarketIdentifierCode { get; }

        /// <summary>
        /// Name of this exchange.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The MIC of the entity that operates this exchange.
        /// </summary>
        [JsonPropertyName("operating_mic")]
        public string OperatingMarketIdentifierCode { get; }

        /// <summary>
        /// The ID used by SIP's to represent this exchange.
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string ParticipantId { get; }

        /// <summary>
        /// Represents the type of exchange.
        /// </summary>
        [JsonPropertyName("type")]
        public ExchangeTypesDto Type { get; }

        /// <summary>
        /// A link to this exchange's website, if one exists.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; }
    }
}
