using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.AggregateBars.PreviousDayBar
{
    public class PreviousDayBarDto
    {
        public PreviousDayBarDto(
            decimal closePrice,
            decimal highPrice,
            decimal lowPrice,
            int? numberOfTransactions,
            decimal openPrice,
            long timestamp,
            decimal tradingVolume,
            decimal? volumeWeightedAveragePrice
            )
        {
            ClosePrice = closePrice;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            NumberOfTransactions = numberOfTransactions;
            OpenPrice = openPrice;
            Timestamp = timestamp;
            TradingVolume = tradingVolume;
            VolumeWeightedAveragePrice = volumeWeightedAveragePrice;
        }

        /// <summary>
        /// The close price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("c")]
        public decimal ClosePrice { get; }

        /// <summary>
        /// The highest price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("h")]
        public decimal HighPrice { get; }

        /// <summary>
        /// The lowest price for the symbol in the given time period.
        /// </summary>
        [JsonPropertyName("l")]
        public decimal LowPrice { get; }

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
        /// The Unix millisecond timestamp for the start of the aggregate window.
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
