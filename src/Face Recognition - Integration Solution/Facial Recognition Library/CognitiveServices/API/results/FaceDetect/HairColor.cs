using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class HairColor : baseResult
    {
        [JsonProperty("color")] public string Color { get; set; }
        [JsonProperty("confidence")] public double Confidence { get; set; }
    }
}