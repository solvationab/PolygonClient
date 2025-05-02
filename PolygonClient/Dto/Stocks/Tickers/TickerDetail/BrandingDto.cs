using System.Text.Json.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers.TickerDetail
{
    public class BrandingDto
    {
        public BrandingDto(string iconUrl, string logoUrl)
        {
            IconUrl = iconUrl;
            LogoUrl = logoUrl;
        }

        /// <summary>
        /// A link to this ticker's company's icon. Icon's are generally smaller, square images that represent the company at a glance. Note that you must provide an API key when accessing this URL. See the "Authentication" section at the top of this page for more details.
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; }

        /// <summary>
        /// A link to this ticker's company's logo. Note that you must provide an API key when accessing this URL.See the "Authentication" section at the top of this page for more details.
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; }
    }
}