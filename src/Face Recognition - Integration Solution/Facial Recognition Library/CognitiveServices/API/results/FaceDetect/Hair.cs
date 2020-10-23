using System.Collections.Generic;
using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class Hair : baseResult
    {
        [JsonProperty("hairColor")] public List<HairColor> HairColor { get; set; }
        [JsonProperty("bald")] public double Bald { get; set; }
        [JsonProperty("invisible")] public bool Invisible { get; set; }
    }
}