// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Facial_Recognition_Library.API.Results;
//
//    var data = GettingStarted.FromJson(jsonString);
//

using System.Text;

namespace Facial_Recognition_Library.API.Results
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;


    public partial class FaceApiFaceDetectResult : baseResult
    {
        public static List<FaceDetectFaceResult> FromJson(string json) => JsonConvert.DeserializeObject<List<FaceDetectFaceResult>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<FaceDetectFaceResult> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}

