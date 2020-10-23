using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Emotion : baseResult
    {
        [JsonProperty("fear")] public long Fear { get; set; }
        [JsonProperty("contempt")] public long Contempt { get; set; }
        [JsonProperty("anger")] public long Anger { get; set; }
        [JsonProperty("disgust")] public long Disgust { get; set; }
        [JsonProperty("neutral")] public long Neutral { get; set; }
        [JsonProperty("happiness")] public long Happiness { get; set; }
        [JsonProperty("sadness")] public long Sadness { get; set; }
        [JsonProperty("surprise")] public long Surprise { get; set; }
    }
}