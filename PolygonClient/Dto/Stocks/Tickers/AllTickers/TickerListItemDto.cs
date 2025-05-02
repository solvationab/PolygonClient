using System;
using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers.AllTickers
{
    public class TickerListItemDto
    {
        public TickerListItemDto(
            bool? active,
            string cik,
            string compositeFigi,
            string currencyName,
            DateTime delistedUtc,
            DateTime lastUpdatedUtc,
            TickerLocalesDto locale,
            MarketTypesDto market,
            string name,
            string primaryExchange,
            string shareClassFigi,
            string ticker,
            string type
            )
        {
            Active = active;
            Cik = cik;
            CompositeFigi = compositeFigi;
            CurrencyName = currencyName;
            DelistedUtc = delistedUtc;
            LastUpdatedUtc = lastUpdatedUtc;
            Locale = locale;
            Market = market;
            Name = name;
            PrimaryExchange = primaryExchange;
            ShareClassFigi = shareClassFigi;
            Ticker = ticker;
            Type = type;
        }

        /// <summary>
        /// Whether or not the asset is actively traded.False means the asset has been delisted.
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; }

        /// <summary>
        /// The CIK number for this ticker.
        /// </summary>
        [JsonPropertyName("cik")]
        public string Cik { get; }

        /// <summary>
        /// The composite OpenFIGI number for this ticker.
        /// </summary>
        [JsonPropertyName("composite_figi")]
        public string CompositeFigi { get; }

        /// <summary>
        /// The name of the currency that this asset is traded with.
        /// </summary>
        [JsonPropertyName("currency_name")]
        public string CurrencyName { get; }

        /// <summary>
        /// The last date that the asset was traded.
        /// </summary>
        [JsonPropertyName("delisted_utc")]
        public DateTime DelistedUtc { get; }

        /// <summary>
        /// The information is accurate up to this time.
        /// </summary>
        [JsonPropertyName("last_updated_utc")]
        public DateTime LastUpdatedUtc { get; }

        /// <summary>
        /// The locale of the asset.
        /// </summary>
        [JsonPropertyName("locale")]
        public TickerLocalesDto Locale { get; }

        /// <summary>
        /// The market type of the asset.
        /// </summary>
        [JsonPropertyName("market")]
        public MarketTypesDto Market { get; }

        /// <summary>
        /// The name of the asset.For stocks/equities this will be the companies registered name. For crypto/fx this will be the name of the currency or coin pair.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The ISO code of the primary listing exchange for this asset.
        /// </summary>
        [JsonPropertyName("primary_exchange")]
        public string PrimaryExchange { get; }

        /// <summary>
        /// The share Class OpenFIGI number for this ticker.Find more information here
        /// </summary>
        [JsonPropertyName("share_class_figi")]
        public string ShareClassFigi { get; }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        [JsonPropertyName("ticker")]
        public string Ticker { get; }

        /// <summary>
        /// The type of the asset.Find the types that we support via our Ticker Types API.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }
    }
}
