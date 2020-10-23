using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class HeadPose : baseResult
    {
        [JsonProperty("roll")] public double Roll { get; set; }
        [JsonProperty("pitch")] public long Pitch { get; set; }
        [JsonProperty("yaw")] public double Yaw { get; set; }
    }
}