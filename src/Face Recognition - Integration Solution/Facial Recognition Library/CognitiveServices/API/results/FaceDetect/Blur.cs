using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Blur : baseResult
    {
        [JsonProperty("blurLevel")] public string BlurLevel { get; set; }
        [JsonProperty("value")] public long Value { get; set; }
    }
}