using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks
{
    public enum LocalesDto
    {
        [EnumMember(Value = "us")]
        Us,

        [EnumMember(Value = "global")]
        Global,
    }
}