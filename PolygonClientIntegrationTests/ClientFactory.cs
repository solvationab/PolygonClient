using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PolygonClient;
using PolygonClient.Config;
using PolygonClient.Extensions;

namespace PolygonClientIntegrationTests
{
    public class ClientFactory
    {
        public static IPolygonClient CreateClient()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddUserSecrets<ClientFactory>()
                .Build();

            var polygonConfig = config.GetRequiredConfig<PolygonConfig>("Polygon");

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddHttpClient()
                .AddPolygonClient(polygonConfig)
                .BuildServiceProvider();

            return serviceProvider.GetRequiredService<IPolygonClient>();
        }
    }
}
