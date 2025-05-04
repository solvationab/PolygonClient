using FluentAssertions;

namespace PolygonClientIntegrationTests.Api.Stocks.MarketOperations
{
    [TestClass]
    public class GetExchangesTests
    {
        [TestMethod]
        public async Task GetExchanges()
        {
            var client = ClientFactory.CreateClient();

            var response = await client.GetExchanges();

            response.Should().NotBeNull();
            response.Status.Should().Be("OK");
            response.Results.Should().NotBeNull();
            response.Results.Should().NotBeEmpty();
        }
    }
}
