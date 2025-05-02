using System;
using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.AggregateBars.DailyTickerSummary
{
    public class DailyTickerSummaryResponse 
    {
        public DailyTickerSummaryResponse(
            decimal? afterHours,
            decimal? close,
            DateTime from,
            decimal highestPrice,
            decimal? lowestPrice,
            decimal? openPrice,
            bool isOtc,
            decimal? preMarketPrice,
            string status,
            string symbol,
            decimal tradingVolume
            )
        {
            AfterHours = afterHours;
            Close = close;
            From = from;
            HighestPrice = highestPrice;
            LowestPrice = lowestPrice;
            OpenPrice = openPrice;
            IsOtc = isOtc;
            PreMarketPrice = preMarketPrice;
            Status = status;
            Symbol = symbol;
            TradingVolume = tradingVolume;
        }

        /// <summary>
        /// The close price of the ticker symbol in after hours trading.
        /// </summary>
        [JsonPropertyName("afterHours")]
        public decimal? AfterHours { get; }

        /// <summary>
        /// The close price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("close")]
        public decimal? Close { get; }

        /// <summary>
        /// The requested date.
        /// </summary>
        [JsonPropertyName("from")]
        public DateTime From { get; }

        /// <summary>
        /// The highest price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("high")]
        public decimal HighestPrice { get; }

        /// <summary>
        /// The lowest price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("low")]
        public decimal? LowestPrice { get; }

        /// <summary>
        /// The open price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("open")]
        public decimal? OpenPrice { get; }

        /// <summary>
        /// Whether or not this aggregate is for an OTC ticker.
        /// </summary>
        [JsonPropertyName("otc")]
        public bool IsOtc { get; }

        /// <summary>
        /// The open price of the ticker symbol in pre-market trading.
        /// </summary>
        [JsonPropertyName("preMarket")]
        public decimal? PreMarketPrice { get; }

        /// <summary>
        /// The status of this request's response.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; }

        /// <summary>
        /// The trading volume of the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("volume")]
        public decimal TradingVolume { get; }
    }
}
