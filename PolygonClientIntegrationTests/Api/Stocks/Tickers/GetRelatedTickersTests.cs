﻿using FluentAssertions;
using PolygonClient.Dto.Stocks.Tickers.RelatedTickers;

namespace PolygonClientIntegrationTests.Api.Stocks.Tickers
{
    [TestClass]
    public class GetRelatedTickersTests
    {
        [TestMethod]
        public async Task GetRelatedTickers()
        {
            var client = ClientFactory.CreateClient();

            var response = await client.GetRelatedTickers("AAPL");

            response.Should().NotBeNull();
            response.RequestId.Should().NotBeNullOrEmpty();
            response.Status.Should().Be("OK");
            response.Results.Should().NotBeNull();
            response.Results.Should().NotBeEmpty();
            response.Results.Should().HaveCountGreaterThan(0);
            response.Results.Should().AllBeOfType<RelatedTickerDto>();
        }
    }
}
