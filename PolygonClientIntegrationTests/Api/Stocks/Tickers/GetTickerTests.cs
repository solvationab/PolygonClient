using FluentAssertions;
using PolygonClient.Dto.Stocks.Tickers;

namespace PolygonClientIntegrationTests.Api.Stocks.Tickers;

[TestClass]
public class GetTickerTests
{
    [TestMethod]
    public async Task GetTicker()
    {
        var client = ClientFactory.CreateClient();
        var response = await client.GetTicker("AAPL");
        response.Should().NotBeNull();
        response.RequestId.Should().NotBeNullOrEmpty();
        response.Status.Should().Be("OK");
        response.Results.Should().NotBeNull();
        response.Results.Should().BeOfType<TickerDetailDto>();
    }
}