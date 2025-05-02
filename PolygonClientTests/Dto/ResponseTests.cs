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
                "message",
                "result"
            );

            response.RequestId.Should().Be("aaa");
            response.Status.Should().Be("ok");
            response.Message.Should().Be("message");
            response.Results.Should().Be("result");
        }
    }
}
