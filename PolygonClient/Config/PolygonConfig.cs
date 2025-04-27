namespace PolygonClient.Config
{
    public class PolygonConfig
    {
        public PolygonConfig(
            string apiKey,
            string baseUrl = "https://api.polygon.io"
            )
        {
            ApiKey = apiKey;
            BaseUrl = baseUrl;
        }

        public string ApiKey { get; }
        public string BaseUrl { get; }
    }
}
