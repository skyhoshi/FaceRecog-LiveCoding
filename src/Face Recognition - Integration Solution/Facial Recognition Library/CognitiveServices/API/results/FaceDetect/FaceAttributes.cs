using System.Collections.Generic;
using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class FaceAttributes : baseResult
    {
        [JsonProperty("emotion")] public Emotion Emotion { get; set; }
        [JsonProperty("glasses")] public string Glasses { get; set; }
        [JsonProperty("age")] public double Age { get; set; }
        [JsonProperty("accessories")] public List<Accessory> Accessories { get; set; }
        [JsonProperty("blur")] public Blur Blur { get; set; }
        [JsonProperty("facialHair")] public FacialHair FacialHair { get; set; }
        [JsonProperty("exposure")] public Exposure Exposure { get; set; }
        [JsonProperty("gender")] public string Gender { get; set; }
        [JsonProperty("headPose")] public HeadPose HeadPose { get; set; }
        [JsonProperty("noise")] public Noise Noise { get; set; }
        [JsonProperty("hair")] public Hair Hair { get; set; }
        [JsonProperty("makeup")] public Makeup Makeup { get; set; }
        [JsonProperty("occlusion")] public Occlusion Occlusion { get; set; }
        [JsonProperty("smile")] public long Smile { get; set; }

    }
}