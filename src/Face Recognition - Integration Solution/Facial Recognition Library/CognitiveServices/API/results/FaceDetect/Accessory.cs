using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Accessory : baseResult
    {
        [JsonProperty("confidence")] public double Confidence { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
    }
}