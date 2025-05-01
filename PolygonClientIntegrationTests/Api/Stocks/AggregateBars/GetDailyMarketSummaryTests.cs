using FluentAssertions;

namespace PolygonClientIntegrationTests.Api.Stocks.AggregateBars
{
    [TestClass]
    public class GetDailyMarketSummaryTests
    {
        [TestMethod]
        public async Task GetDailyMarketSummary()
        {
            var client = ClientFactory.CreateClient();

            var response = await client.GetDailyMarketSummary(DateTime.Now.AddMonths(-12));

            response.Should().NotBeNull();
            response.Status.Should().Be("OK");
            response.Results.Should().NotBeNull();
            response.Results.Should().NotBeEmpty();
        }
    }
}
