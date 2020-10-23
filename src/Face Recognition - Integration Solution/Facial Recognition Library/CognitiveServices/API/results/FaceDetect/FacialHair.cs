using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class FacialHair : baseResult
    {
        [JsonProperty("moustache")] public double Moustache { get; set; }
        [JsonProperty("beard")] public double Beard { get; set; }
        [JsonProperty("sideburns")] public double Sideburns { get; set; }
    }
}