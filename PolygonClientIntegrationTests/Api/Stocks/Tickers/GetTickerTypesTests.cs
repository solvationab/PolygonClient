using FluentAssertions;
using PolygonClient.Dto.Stocks.Tickers;

namespace PolygonClientIntegrationTests.Api.Stocks.Tickers
{
    [TestClass]
    public class GetTickerTypesTests
    {
        [TestMethod]
        public async Task GetTickerTypes()
        {
            var client = ClientFactory.CreateClient();

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
