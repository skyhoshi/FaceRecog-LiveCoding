using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Noise : baseResult
    {
        [JsonProperty("noiseLevel")] public string NoiseLevel { get; set; }
        [JsonProperty("value")] public long Value { get; set; }
    }
}