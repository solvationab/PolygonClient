using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PolygonClient.Dto
{
    public class CollectionResponse<T> : Response<IReadOnlyCollection<T>>
    {
        public CollectionResponse(
            string requestId,
            string status,
            string message,
            IReadOnlyCollection<T> results,
            int? count, 
            string nextUrl
            ) : base(requestId, status, message, results)
        {
            Count = count;
            NextUrl = nextUrl;
        }

        /// <summary>
        /// The total number of results for this request.
        /// </summary>
        [JsonPropertyName("count")] 
        public int? Count { get; }

        /// <summary>
        /// If present, this value can be used to fetch the next page of data.
        /// </summary>
        [JsonPropertyName("next_url")]
        public string NextUrl { get; }
    }
}