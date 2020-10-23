using Newtonsoft.Json;

using J = Newtonsoft.Json.JsonPropertyAttribute;
namespace Facial_Recognition_Library.API.Results
{
    public partial class FaceDetectFaceResult : baseResult
    {
        [JsonProperty("faceId")] public string FaceId { get; set; }
        [JsonProperty("faceAttributes")] public FaceAttributes FaceAttributes { get; set; }
        [JsonProperty("faceLandmarks")]public FaceLandmarks FaceLandmarks { get; set; }
        [JsonProperty("faceRectangle")] public FaceRectangle FaceRectangle { get; set; }

        public string getJsonFaceAttibutes()
        {
            // return JsonConvert.SerializeObject(FaceAttributes, Converter.Settings);
            //The line below replaces the line above as, in our base class we are converting the "Object(this)" to a JSON string. this is applied to all classes
            return FaceAttributes?.ToJSON(); 
        }
        public string getJsonFaceRectangle()
        {
            //return JsonConvert.SerializeObject(FaceRectangle, Converter.Settings);
            //The line below replaces the line above as, in our base class we are converting the "Object(this)" to a JSON string. this is applied to all classes
            return FaceRectangle?.ToJSON();
        }

        public string getJsonFaceLandmarks()
        {
            return FaceLandmarks?.ToJSON();
        }
    }
    public partial class FaceLandmarks : baseResult
    {
        [J("eyeRightTop")] public EyeLeftBottom EyeRightTop { get; set; }
        [J("noseLeftAlarTop")] public Top NoseLeftAlarTop { get; set; }
        [J("eyeLeftTop")] public Top EyeLeftTop { get; set; }
        [J("eyeLeftInner")] public EyeLeftBottom EyeLeftInner { get; set; }
        [J("eyeLeftBottom")] public EyeLeftBottom EyeLeftBottom { get; set; }
        [J("eyeLeftOuter")] public EyeLeftBottom EyeLeftOuter { get; set; }
        [J("eyeRightInner")] public EyeLeftBottom EyeRightInner { get; set; }
        [J("eyeRightBottom")] public EyeRightBottom EyeRightBottom { get; set; }
        [J("eyeRightOuter")] public EyeLeftBottom EyeRightOuter { get; set; }
        [J("eyebrowRightOuter")] public EyeRightBottom EyebrowRightOuter { get; set; }
        [J("eyebrowLeftOuter")] public EyeLeftBottom EyebrowLeftOuter { get; set; }
        [J("eyebrowLeftInner")] public EyeLeftBottom EyebrowLeftInner { get; set; }
        [J("eyebrowRightInner")] public EyeLeftBottom EyebrowRightInner { get; set; }
        [J("mouthRight")] public EyeLeftBottom MouthRight { get; set; }
        [J("mouthLeft")] public EyeLeftBottom MouthLeft { get; set; }
        [J("noseLeftAlarOutTip")] public EyeRightBottom NoseLeftAlarOutTip { get; set; }
        [J("noseRootRight")] public EyeLeftBottom NoseRootRight { get; set; }
        [J("underLipBottom")] public EyeLeftBottom UnderLipBottom { get; set; }
        [J("noseRightAlarTop")] public EyeLeftBottom NoseRightAlarTop { get; set; }
        [J("noseRightAlarOutTip")] public EyeLeftBottom NoseRightAlarOutTip { get; set; }
        [J("noseRootLeft")] public EyeLeftBottom NoseRootLeft { get; set; }
        [J("pupilLeft")] public EyeLeftBottom PupilLeft { get; set; }
        [J("noseTip")] public EyeLeftBottom NoseTip { get; set; }
        [J("pupilRight")] public EyeLeftBottom PupilRight { get; set; }
        [J("upperLipBottom")] public EyeLeftBottom UpperLipBottom { get; set; }
        [J("underLipTop")] public Top UnderLipTop { get; set; }
        [J("upperLipTop")] public EyeLeftBottom UpperLipTop { get; set; }
    }
    public partial class EyeLeftBottom : baseResult
    {
        [J("x")] public double X { get; set; }
        [J("y")] public double Y { get; set; }
    }

    public partial class Top : baseResult
    {
        [J("x")] public long X { get; set; }
        [J("y")] public double Y { get; set; }
    }

    public partial class EyeRightBottom : baseResult
    {
        [J("x")] public double X { get; set; }
        [J("y")] public long Y { get; set; }
    }
}