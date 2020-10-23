using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facial_Recognition_Library.API;
using Facial_Recognition_Library.Data.tbls;
using Microsoft.ProjectOxford.Face.Contract;

namespace Facial_Recognition_Library.Controls
{
    public class ToolStripMenus : ToolStripMenusMethods
    {
        public static ToolStripMenuProcessResult OpenImgFromFileSystem(ref object sender, EventArgs e)
        {
            ToolStripMenuProcessResult methodResult = new ToolStripMenuProcessResult();

            //TODO: Move this to the libary. : openToolStripMenuItem_Click
            string fileLocation = @"W:\Example Pictures\imgNov82017.png";

            var MyCurrentImage = Image.FromFile(fileLocation);

            using (MemoryStream ms = new MemoryStream())
            {
                MyCurrentImage.Save(ms, ImageFormat.Png);
                try
                {
                    Microsoft.ProjectOxford.Face.Contract.Face face;
                    try
                    {
                        var faces = AsyncHelpers.RunSync(() => ProjectOxfordAPI.DetectFace(ms));
                        face = faces.First();
                    }
                    catch (Exception f)
                    {
                        face = new Face();
                    }

                    if (face.FaceId != Guid.Empty)
                    {
                        MyFace newface = new MyFace
                        {
                            FaceID = face.FaceId,
                            FaceAttributes = Newtonsoft.Json.JsonConvert.SerializeObject(face.FaceAttributes),
                            FaceLandmarks = Newtonsoft.Json.JsonConvert.SerializeObject(face.FaceLandmarks),
                            FaceRectangle = Newtonsoft.Json.JsonConvert.SerializeObject(face.FaceRectangle),
                            ImageBytes = ms.ToArray()
                        };

                        using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
                        {
                            db.MyFaces.Add(newface);
                            db.SaveChanges();

                            foreach (var faceItem in db.MyFaces)
                            {
                                System.Diagnostics.Debug.WriteLine($"{faceItem.FaceID.ToString()} - {faceItem.FaceRectangle}");
                            }
                        }

                    }
                }
                catch (Exception s)
                {
                    //MessageBox.Show(e.Message);
                    //throw e;
                }
            }

            return methodResult;
        }

        public static ToolStripMenuProcessResult CreateNewFaceEntryInDatabase(ref object sender, EventArgs eventArgs)
        {
            ToolStripMenuProcessResult methodResult = new ToolStripMenuProcessResult();
            //


            return methodResult;
        }
    }

    public class ToolStripMenusMethods
    {
    }

    public class ToolStripMenuProcessResult
    {
        public bool Success { get; set; }
        public string Reason { get; set; }

    }
}
