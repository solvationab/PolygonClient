using FluentAssertions;
using PolygonClient.Dto.Stocks.Tickers.TickerDetail;

namespace PolygonClientIntegrationTests.Api.Stocks.Tickers;

[TestClass]
public class GetTickerDetailTests
{
    [TestMethod]
    public async Task GetTickerDetail()
    {
        var client = ClientFactory.CreateClient();

        var response = await client.GetTickerDetail("AAPL");

        response.Should().NotBeNull();
        response.RequestId.Should().NotBeNullOrEmpty();
        response.Status.Should().Be("OK");
        response.Results.Should().NotBeNull();
        response.Results.Should().BeOfType<TickerDetailDto>();
    }
}