using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public class TickerTypeDto
    {
        public TickerTypeDto(
            AssetClassesDto assetClass,
            string code,
            string description,
            TickerLocalesDto locale
            )
        {
            AssetClass = assetClass;
            Code = code;
            Description = description;
            Locale = locale;
        }

        /// <summary>
        /// An identifier for a group of similar financial instruments.
        /// </summary>
        [JsonPropertyName("asset_class")]
        public AssetClassesDto AssetClass { get; }

        /// <summary>
        /// A code used by Polygon.io to refer to this ticker type.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; }

        /// <summary>
        /// A short description of this ticker type.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// An identifier for a geographical location.
        /// </summary>
        [JsonPropertyName("locale")]
        public TickerLocalesDto Locale { get; }
    }
}