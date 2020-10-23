using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Makeup : baseResult
    {
        [JsonProperty("eyeMakeup")] public bool EyeMakeup { get; set; }
        [JsonProperty("lipMakeup")] public bool LipMakeup { get; set; }
    }
}