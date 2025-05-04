using FluentAssertions;

namespace PolygonClientIntegrationTests.Api.Stocks.TechnicalIndicators
{
    [TestClass]
    public class GetSimpleMovingAverageTests
    {
        [TestMethod]
        public async Task GetSimpleMovingAverage()
        {
            var client = ClientFactory.CreateClient();

            var result = await client.GetSimpleMovingAverage("AAPL");

            result.Should().NotBeNull();
            result.Status.Should().Be("OK");
        }
    }
}
