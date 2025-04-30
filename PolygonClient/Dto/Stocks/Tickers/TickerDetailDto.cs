using System;
using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public class TickerDetailDto
    {
        public TickerDetailDto(
            bool active,
            AddressDto address,
            BrandingDto branding,
            string cik,
            string compositeFigi,
            string currencyName,
            DateTime? delistedUtc,
            string description,
            string homepageUrl,
            DateTime? listDate,
            TickerLocalesDto locale,
            MarketTypesDto market,
            decimal? marketCap,
            string name,
            string phoneNumber,
            string primaryExchange,
            long roundLot,
            string shareClassFigi,
            long? shareClassSharesOutstanding,
            string sicCode,
            string sicDescription,
            string ticker,
            string tickerRoot,
            string tickerSuffix,
            long totalEmployees,
            string type,
            long? weightedSharesOutstanding
            )
        {
            Active = active;
            Address = address;
            Branding = branding;
            Cik = cik;
            CompositeFigi = compositeFigi;
            CurrencyName = currencyName;
            DelistedUtc = delistedUtc;
            Description = description;
            HomepageUrl = homepageUrl;
            ListDate = listDate;
            Locale = locale;
            Market = market;
            MarketCap = marketCap;
            Name = name;
            PhoneNumber = phoneNumber;
            PrimaryExchange = primaryExchange;
            RoundLot = roundLot;
            ShareClassFigi = shareClassFigi;
            ShareClassSharesOutstanding = shareClassSharesOutstanding;
            SicCode = sicCode;
            SicDescription = sicDescription;
            Ticker = ticker;
            TickerRoot = tickerRoot;
            TickerSuffix = tickerSuffix;
            TotalEmployees = totalEmployees;
            Type = type;
            WeightedSharesOutstanding = weightedSharesOutstanding;
        }

        /// <summary>
        /// Whether or not the asset is actively traded.False means the asset has been delisted.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; }

        /// <summary>
        /// Company headquarters address details.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressDto Address { get; }

        /// <summary>
        /// Provides URLs aiding in visual identification.
        /// </summary>
        [JsonPropertyName("branding")]
        public BrandingDto Branding { get; }

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
        public DateTime? DelistedUtc { get; }

        /// <summary>
        /// A description of the company and what they do/offer.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// The URL of the company's website homepage.
        /// </summary>
        [JsonPropertyName("homepage_url")]
        public string HomepageUrl { get; }

        /// <summary>
        /// The date that the symbol was first publicly listed.
        /// </summary>
        [JsonPropertyName("list_date")]
        public DateTime? ListDate { get; }

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
        /// The most recent close price of the ticker multiplied by weighted outstanding shares.
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; }

        /// <summary>
        /// The name of the asset. For stocks/equities this will be the companies registered name. For crypto/fx this will be the name of the currency or coin pair.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The phone number for the company behind this ticker.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; }

        /// <summary>
        /// The ISO code of the primary listing exchange for this asset.
        /// </summary>
        [JsonPropertyName("primary_exchange")]
        public string PrimaryExchange { get; }

        /// <summary>
        /// Round lot size of this security.
        /// </summary>
        [JsonPropertyName("round_lot")]
        public long RoundLot { get; }

        /// <summary>
        /// The share Class OpenFIGI number for this ticker.
        /// </summary>
        [JsonPropertyName("share_class_figi")]
        public string ShareClassFigi { get; }

        /// <summary>
        /// The recorded number of outstanding shares for this particular share class.
        /// </summary>
        [JsonPropertyName("share_class_shares_outstanding")]
        public long? ShareClassSharesOutstanding { get; }

        /// <summary>
        /// The standard industrial classification code for this ticker.For a list of SIC Codes, see the SEC's SIC Code List.
        /// </summary>
        [JsonPropertyName("sic_code")]
        public string SicCode { get; }

        /// <summary>
        /// A description of this ticker's SIC code.
        /// </summary>
        [JsonPropertyName("sic_description")]
        public string SicDescription { get; }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        [JsonPropertyName("ticker")]
        public string Ticker { get; }

        /// <summary>
        /// The root of a specified ticker. For example, the root of BRK.A is BRK.
        /// </summary>
        [JsonPropertyName("ticker_root")]
        public string TickerRoot { get; }

        /// <summary>
        /// The suffix of a specified ticker. For example, the suffix of BRK.A is A.
        /// </summary>
        [JsonPropertyName("ticker_suffix")]
        public string TickerSuffix { get; }

        /// <summary>
        /// The approximate number of employees for the company.
        /// </summary>
        [JsonPropertyName("total_employees")]
        public long TotalEmployees { get; }

        /// <summary>
        /// The type of the asset.Find the types that we support via our Ticker Types API.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// The shares outstanding calculated assuming all shares of other share classes are converted to this share class.
        /// </summary>
        [JsonPropertyName("weighted_shares_outstanding")]
        public long? WeightedSharesOutstanding { get; }
    }
}
