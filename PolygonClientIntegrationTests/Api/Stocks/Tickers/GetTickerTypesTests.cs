using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PolygonClient;
using PolygonClient.Config;
using PolygonClient.Dto.Stocks.Tickers;
using PolygonClient.Extensions;

namespace PolygonClientIntegrationTests.Api.Stocks.Tickers
{
    [TestClass]
    public class GetTickerTypesTests
    {
        [TestMethod]
        public async Task GetTickerTypes()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json") 
                .AddEnvironmentVariables()
                .AddUserSecrets<GetTickerTypesTests>()
                .Build();

            var polygonConfig = config.GetRequiredConfig<PolygonConfig>("Polygon");

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddHttpClient()
                .AddPolygonClient(polygonConfig)
                .BuildServiceProvider();

            var client = serviceProvider.GetRequiredService<IPolygonClient>();

            var response = await client.GetTickerTypes();

            response.Should().NotBeNull();
            response.RequestId.Should().NotBeNullOrEmpty();
            response.Status.Should().Be("OK");
            response.Results.Should().NotBeNull();
            response.Results.Should().NotBeEmpty();
            response.Results.Should().HaveCountGreaterThan(0);
            response.Results.Should().AllBeOfType<TickerTypeDto>();
        }
    }
}
