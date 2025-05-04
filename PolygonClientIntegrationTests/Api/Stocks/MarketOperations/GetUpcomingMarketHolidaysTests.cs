using FluentAssertions;
using PolygonClient.Dto.Stocks.MarketOperations.UpcomingMarketHolidays;

namespace PolygonClientIntegrationTests.Api.Stocks.MarketOperations
{
    [TestClass]
    public class GetUpcomingMarketHolidaysTests
    {
        [TestMethod]
        public async Task GetUpcomingMarketHolidays()
        {
            var client = ClientFactory.CreateClient();

            var response = await client.GetUpcomingMarketHolidays();

            response.Should().NotBeNull();
            response.Should().NotBeEmpty();
            response.Should().AllBeOfType<UpcomingMarketHolidayDto>();
        }
    }
}
