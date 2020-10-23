using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    public partial class FaceRectangle : baseResult
    {

        public FaceRectangle() { }
        public FaceRectangle(string faceRectangle)
        {
            if (!string.IsNullOrWhiteSpace(faceRectangle))
            {
                var i = JsonConvert.DeserializeObject<FaceRectangle>(faceRectangle, Converter.Settings);
                this.Left = i.Left;
                this.Height = i.Height;
                this.Top = i.Top;
                this.Width = i.Width;
            }
        }

        [JsonProperty("left")] public long Left { get; set; }
        [JsonProperty("height")] public long Height { get; set; }
        [JsonProperty("top")] public long Top { get; set; }
        [JsonProperty("width")] public long Width { get; set; }
    }
}