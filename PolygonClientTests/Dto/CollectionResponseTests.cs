using FluentAssertions;
using PolygonClient.Dto;

namespace PolygonClientTests.Dto
{
    [TestClass]
    public class CollectionResponseTests
    {
        [TestMethod]
        public void Create()
        {
            var collectionResponse = new CollectionResponse<string>(
                requestId: "123",
                status: "success",
                results: new List<string> { "result1", "result2" },
                count: 2,
                nextUrl: "http://example.com/next"
            );

            collectionResponse.RequestId.Should().Be("123");
            collectionResponse.Status.Should().Be("success");
            collectionResponse.Results.Should().BeEquivalentTo(new List<string> { "result1", "result2" });
            collectionResponse.Count.Should().Be(2);
            collectionResponse.NextUrl.Should().Be("http://example.com/next");
        }
    }
}
