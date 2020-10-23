using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Facial_Recognition_Library.API
{
    /// <summary>
    /// This Class is used to build a Query string for direct access calls to the Face API. (not ment to be used with the Project Oxford NuGet Package)
    /// </summary>
    public class QueryStringBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IncludeFaceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IncludeFaceLandmarks { get; set; }

        /// <inheritdoc />
        [Flags]
        public enum faceAttributes
        {
            age = 1 << 0,
            gender = 1 << 1,
            headPose = 1 << 2,
            smile = 1 << 3,
            facialHair = 1 << 4,
            glasses = 1 << 5,
            emotion = 1 << 6,
            hair = 1 << 7,
            makeup = 1 << 8,
            occlusion = 1 << 9,
            accessories = 1 << 10,
            blur = 1 << 11,
            exposure = 1 << 12,
            noise = 1 << 13
            //age|gender|headPose|smile|facialHair|glasses|emotion|hair|makeup|occlusion|accessories|blur|exposure|noise
        }
        public faceAttributes IncludeFaceAttributes { get; set; }

        public override string ToString()
        {
            string rtnString = $"returnFaceId={IncludeFaceID}&";
            rtnString += $"returnLandmarks={IncludeFaceLandmarks}&";
            //rtnString += $"returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";
            rtnString += $"retrunFaceAttributes={IncludeFaceAttributes.ToString()}";
            //System.Diagnostics.Debug.WriteLine(IncludeFaceAttributes.ToString());
            return rtnString;
        }
    }

    public static class EnumFaceAttributesExtensions
    {
        public static bool HasFlagFast(this QueryStringBuilder.faceAttributes value, QueryStringBuilder.faceAttributes flag)
        {
            return (value & flag) != 0;
        }
    }
}

//FaceAttributeType.age 
// | FaceAttributeType.gender
// | FaceAttributeType.headPose
// | FaceAttributeType.smile 
// | FaceAttributeType.facialHair
// | FaceAttributeType.glasses 
// | FaceAttributeType.emotion 
// | FaceAttributeType.hair 
// | FaceAttributeType.makeup 
// | FaceAttributeType.occlusion 
// | FaceAttributeType.accessories
// | FaceAttributeType.blur 
// | FaceAttributeType.exposure
// | FaceAttributeType.noise

//FaceAttributeType.Accessories | FaceAttributeType.Age