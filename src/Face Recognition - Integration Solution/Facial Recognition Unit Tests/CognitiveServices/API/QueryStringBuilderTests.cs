using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facial_Recognition_Library.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Facial_Recognition_Library.API.QueryStringBuilder.faceAttributes;
namespace Facial_Recognition_Library.API.Tests
{
    [TestClass()]
    public class QueryStringBuilderTests
    {
        [TestMethod()]
        public void ToStringQueryStringBuilderToStringTest()
        {
            QueryStringBuilder.faceAttributes ev = age | gender | headPose | smile | facialHair | glasses | emotion | hair | makeup | occlusion | accessories | blur | exposure | noise;
            Facial_Recognition_Library.API.QueryStringBuilder queryStringBuilder = new QueryStringBuilder();
            queryStringBuilder.IncludeFaceAttributes = ev;

            System.Diagnostics.Debug.WriteLine(queryStringBuilder.ToString());



        }
    }
}