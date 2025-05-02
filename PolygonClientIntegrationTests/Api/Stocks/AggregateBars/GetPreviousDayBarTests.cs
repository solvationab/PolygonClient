using FluentAssertions;
using PolygonClient.Dto.Stocks.AggregateBars.PreviousDayBar;

namespace PolygonClientIntegrationTests.Api.Stocks.AggregateBars
{
    [TestClass]
    public class GetPreviousDayBarTests
    {
        [TestMethod]
        public async Task GetPreviousDayBar()
        {
            var client = ClientFactory.CreateClient();

            var response = await client.GetPreviousDayBar("AAPL");

            response.Should().NotBeNull();
            response.Status.Should().Be("OK");
            response.RequestId.Should().NotBeNullOrEmpty();
            response.Results.Should().AllBeOfType<PreviousDayBarDto>();
        }
    }
}
