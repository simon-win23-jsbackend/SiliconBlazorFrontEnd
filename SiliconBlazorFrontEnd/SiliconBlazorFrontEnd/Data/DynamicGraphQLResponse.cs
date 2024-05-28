using System.Text.Json;
using System.Text.Json.Serialization;

namespace SiliconBlazorFrontEnd.Data;

public class DynamicGraphQLResponse
{
    [JsonPropertyName("data")]
    public JsonElement Data { get; set; }
}
