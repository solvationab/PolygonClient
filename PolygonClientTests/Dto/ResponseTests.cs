using FluentAssertions;
using PolygonClient.Dto;

namespace PolygonClientTests.Dto
{
    [TestClass]
    public class ResponseTests
    {
        [TestMethod]
        public void Create()
        {
            var response = new Response<string>(
                "aaa",
                "ok",
                "result"
            );

            response.RequestId.Should().Be("aaa");
            response.Status.Should().Be("ok");
            response.Results.Should().Be("result");
        }
    }
}
