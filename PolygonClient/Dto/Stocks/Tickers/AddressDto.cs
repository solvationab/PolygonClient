using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public class AddressDto
    {
        public AddressDto(string address1, string address2, string city, string postalCode, string state)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            PostalCode = postalCode;
            State = state;
        }

        /// <summary>
        /// The first line of the company's headquarters address.
        /// </summary>
        [JsonPropertyName("address1")]
        public string Address1 { get; }

        /// <summary>
        /// The second line of the company's headquarters address, if applicable.
        /// </summary>
        [JsonPropertyName("address2")]
        public string Address2 { get; }

        /// <summary>
        /// The city of the company's headquarters address.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; }

        /// <summary>
        /// The postal code of the company's headquarters address.
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; }

        /// <summary>
        /// The state of the company's headquarters address.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; }
    }
}