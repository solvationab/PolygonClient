using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.AggregateBars.DailyMarketSummary
{
    public class DailyMarketSummaryDto
    {
        public DailyMarketSummaryDto(
            string tradeSymbol,
            decimal closePrice,
            decimal highestPrice,
            decimal lowestPrice,
            int? numberOfTransactions,
            decimal openPrice,
            bool? otc,
            long timestamp,
            decimal tradingVolume,
            decimal? volumeWeightedAveragePrice
            )
        {
            TradeSymbol = tradeSymbol;
            ClosePrice = closePrice;
            HighestPrice = highestPrice;
            LowestPrice = lowestPrice;
            NumberOfTransactions = numberOfTransactions;
            OpenPrice = openPrice;
            Otc = otc;
            Timestamp = timestamp;
            TradingVolume = tradingVolume;
            VolumeWeightedAveragePrice = volumeWeightedAveragePrice;
        }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        [JsonPropertyName("T")]
        public string TradeSymbol { get; }

        /// <summary>
        /// The close price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("c")]
        public decimal ClosePrice { get; }

        /// <summary>
        /// The highest price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("h")]
        public decimal HighestPrice { get; }

        /// <summary>
        /// The lowest price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("l")]
        public decimal LowestPrice { get; }

        /// <summary>
        /// The number of transactions in the aggregate window.
        /// </summary>
        [JsonPropertyName("n")]
        public int? NumberOfTransactions { get; }

        /// <summary>
        /// The open price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("o")]
        public decimal OpenPrice { get; }

        /// <summary>
        /// Whether or not this aggregate is for an OTC ticker.
        /// </summary>
        [JsonPropertyName("otc")]
        public bool? Otc { get; }

        /// <summary>
        /// The Unix millisecond timestamp for the end of the aggregate window.
        /// </summary>
        [JsonPropertyName("t")]
        public long Timestamp { get; }

        /// <summary>
        /// The trading volume of the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("v")]
        public decimal TradingVolume { get; }

        /// <summary>
        /// The volume weighted average price.
        /// </summary>
        [JsonPropertyName("vw")]
        public decimal? VolumeWeightedAveragePrice { get; }
    }
}
