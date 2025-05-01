using FluentAssertions;
using PolygonClient.Dto;
using PolygonClient.Dto.Stocks.AggregateBars.CustomBars;

namespace PolygonClientIntegrationTests.Api.Stocks.AggregateBars
{
    [TestClass]
    public class GetCustomBarsTests
    {
        [TestMethod]
        public async Task GetCustomBars()
        {
            var polygonClient = ClientFactory.CreateClient();

            var response = await polygonClient.GetCustomBars(
                "AAPL", 
                1, 
                TimespansDto.Day, 
                DateTime.Now.AddMonths(-6), 
                DateTime.Now.AddMonths(-5)
                );

            response.Should().NotBeNull();
            response.Status.Should().Be("OK");
            response.Results.Should().NotBeNull();
            response.Results.Should().AllBeOfType<CustomBarDto>();
        }
    }
}
