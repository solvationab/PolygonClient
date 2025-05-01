using System.Runtime.Serialization;

namespace PolygonClient.Dto
{
    public enum OrderTypesDto
    {
        [EnumMember(Value = "asc")]
        Asc,

        [EnumMember(Value = "desc")]
        Desc,
    }
}