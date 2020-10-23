using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Exposure : baseResult
    {
        [JsonProperty("exposureLevel")] public string ExposureLevel { get; set; }
        [JsonProperty("value")] public long Value { get; set; }
    }
}