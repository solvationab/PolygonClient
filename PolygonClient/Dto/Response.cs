using System.Text.Json.Serialization;

namespace PolygonClient.Dto
{
    public class Response<T>
    {
        public Response(string requestId, string status, T results)
        {
            RequestId = requestId;
            Status = status;
            Results = results;
        }

        /// <summary>
        /// A request id assigned by the server.
        /// </summary>
        [JsonPropertyName("request_id")] 
        public string RequestId { get; }

        /// <summary>
        /// The status of this request's response.
        /// </summary>
        [JsonPropertyName("status")] 
        public string Status { get; }

        /// <summary>
        /// The results of the request. The type of this property will depend on the endpoint that was called.
        /// </summary>
        [JsonPropertyName("results")] 
        public T Results { get; }
    }
}
