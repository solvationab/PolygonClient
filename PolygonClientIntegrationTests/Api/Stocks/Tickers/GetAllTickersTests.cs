using FluentAssertions;
using PolygonClient.Dto.Stocks.Tickers;

namespace PolygonClientIntegrationTests.Api.Stocks.Tickers;

[TestClass]
public class GetAllTickersTests
{
    [TestMethod]
    public async Task GetAllTickers()
    {
        var client = ClientFactory.CreateClient();

        var response = await client.GetAllTickers();

        response.Should().NotBeNull();
        response.RequestId.Should().NotBeNullOrEmpty();
        response.Status.Should().Be("OK");
        response.Results.Should().NotBeNull();
        response.Results.Should().NotBeEmpty();
        response.Results.Should().HaveCountGreaterThan(0);
        response.Results.Should().AllBeOfType<TickerListItemDto>();
    }
}