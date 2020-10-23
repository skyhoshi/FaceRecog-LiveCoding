using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facial_Recognition_Library.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Facial_Recognition_Library.API.Results;
using Facial_Recognition_Library.Data;
using Facial_Recognition_Library.Data.tbls;

namespace Facial_Recognition_Library.API.Tests
{
    [TestClass()]
    public class API_CognitiveServiceAPI_Tests
    {
        [TestMethod()]
        public void ToStringQueryStringBuilderToStringTest()
        {
            Facial_Recognition_Library.API.QueryStringBuilder qsb = new QueryStringBuilder();
            qsb.IncludeFaceAttributes = QueryStringBuilder.faceAttributes.age | QueryStringBuilder.faceAttributes.emotion;
            Assert.IsTrue(string.IsNullOrWhiteSpace(qsb.ToString()));
        }
        [TestMethod]
        public void SendImageToService_Test()
        {
            Facial_Recognition_Library.API.CognitiveServiceAPI capi = new Facial_Recognition_Library.API.CognitiveServiceAPI();
            var client = new HttpClient();
            var rtn = capi.RequestFaceDetect(@"W:\Example Pictures\MyImage.png", ref client);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(rtn));

            var data = FaceApiFaceDetectResult.FromJson(rtn).First();

            Facial_Recognition_Library.Data.LiveEduFaceModel fm = new LiveEduFaceModel();
            MyFace face = new MyFace
            {
                FaceID = Guid.Parse(data.FaceId),
                FaceAttributes = data.getJsonFaceAttibutes(),
                FaceRectangle = data.getJsonFaceRectangle(),
                //BitmapImage = Image.FromFile(@"W:\Example Pictures\MyImage.png")
                ImageBytes = Facial_Recognition_Library.API.CognitiveServiceAPI.GetImageAsByteArray(@"W:\Example Pictures\MyImage.png")
            };

            using (var db = new LiveEduFaceModel())
            {
                db.MyFaces.Add(face);
                db.SaveChanges();

                foreach (var faceItem in db.MyFaces)
                {
                    System.Diagnostics.Debug.WriteLine($"{faceItem.FaceID.ToString()} - {faceItem.FaceRectangle}");
                }
            }
        }
    }
}