using System.Collections.Generic;

namespace PolygonClient.Dto.Stocks.AggregateBars
{
    public class AggregateBarsResponse<T> : Response<IReadOnlyCollection<T>>
    {
        public AggregateBarsResponse(
            string ticker,
            bool adjusted,
            string queryCount,
            string resultsCount,
            string requestId, 
            string status, 
            IReadOnlyCollection<T> results,
            string nextUrl = null
            ) : base(requestId, status, results)
        {
            Ticker = ticker;
            Adjusted = adjusted;
            QueryCount = queryCount;
            ResultsCount = resultsCount;
            NextUrl = nextUrl;
        }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        public string Ticker { get; }

        /// <summary>
        /// Whether or not this response was adjusted for splits.
        /// </summary>
        public bool Adjusted { get; }

        /// <summary>
        /// The number of aggregates (minute or day) used to generate the response.
        /// </summary>
        public string QueryCount { get; }

        /// <summary>
        /// The total number of results for this request.
        /// </summary>
        public string ResultsCount { get; }

        /// <summary>
        /// If present, this value can be used to fetch the next page of data.
        /// </summary>
        public string NextUrl { get; }
    }
}
