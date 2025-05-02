using FluentAssertions;

namespace PolygonClientIntegrationTests.Api.Stocks.AggregateBars
{
    [TestClass]
    public class GetDailyTickerSummaryTests
    {
        [TestMethod]
        public async Task GetDailyTickerSummary()
        {
            var client = ClientFactory.CreateClient();

            var response = await client.GetDailyTickerSummary("AAPL", DateTime.Now.AddDays(-400));

            response.Should().NotBeNull();
        }
    }
}
