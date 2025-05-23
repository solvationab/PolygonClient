﻿using System.Text.Json.Serialization;

namespace PolygonClient.Dto
{
    public class Response<T> : Response
    {
        public Response(string requestId, string status, string message, T results) : base(requestId, status, message)
        {
            Results = results;
        }

        /// <summary>
        /// The results of the request. The type of this property will depend on the endpoint that was called.
        /// </summary>
        [JsonPropertyName("results")]
        public T Results { get; }
    }

    public class Response
    {
        public Response(string requestId, string status, string message)
        {
            RequestId = requestId;
            Status = status;
            Message = message;
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
        /// The error message if the request was not successful.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; }
    }
}
