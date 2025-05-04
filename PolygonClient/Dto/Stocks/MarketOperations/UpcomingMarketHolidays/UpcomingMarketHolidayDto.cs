using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.MarketOperations.UpcomingMarketHolidays
{
    public class UpcomingMarketHolidayDto
    {
        public UpcomingMarketHolidayDto(
            string close,
            string date,
            string exchange,
            string name,
            string open,
            string status
            )
        {
            Close = close;
            Date = date;
            Exchange = exchange;
            Name = name;
            Open = open;
            Status = status;
        }

        /// <summary>
        /// The market close time on the holiday(if it's not closed).
        /// </summary>
        [JsonPropertyName("close")]
        public string Close { get; }

        /// <summary>
        /// The date of the holiday.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; }

        /// <summary>
        /// Which market the record is for.
        /// </summary>
        [JsonPropertyName("exchange")]
        public string Exchange { get; }

        /// <summary>
        /// The name of the holiday.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The market open time on the holiday (if it's not closed).
        /// </summary>
        [JsonPropertyName("open")]
        public string Open { get; }

        /// <summary>
        /// The status of the market on the holiday.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; }
    }
}
