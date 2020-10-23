using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Occlusion : baseResult
    {
        [JsonProperty("foreheadOccluded")] public bool ForeheadOccluded { get; set; }
        [JsonProperty("eyeOccluded")] public bool EyeOccluded { get; set; }
        [JsonProperty("mouthOccluded")] public bool MouthOccluded { get; set; }
    }
}