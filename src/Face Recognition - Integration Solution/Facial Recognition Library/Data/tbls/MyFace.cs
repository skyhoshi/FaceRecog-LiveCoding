using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Facial_Recognition_Library.API.Results;
using Facial_Recognition_Library.ImageManagement;

namespace Facial_Recognition_Library.Data.tbls
{
    public class MyFace
    {
        [System.ComponentModel.DataAnnotations.Key(), System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        //public virtual Guid FKSystemUserID { get; set; }

        public virtual ApplicationUser FKSystemApplicationUser { get; set; }

        public Guid FaceID { get; set; }
        public string FaceAttributes { get; set; }
        public string FaceLandmarks { get; set; }
        public string FaceRectangle { get; set; }
        public Guid? FaceListPersistantID { get; set; }

        public string FacePersonID { get; set; }

        /// <summary>
        /// Date the Data was last sent to the API : Data Sent to the API may only exist for 24 hours
        /// </summary>
        public DateTime? DateLastDetected { get; set; } = DateTime.Now;
        public DateTime? DateAddedToFaceList { get; set; } = DateTime.Now;
        public DateTime? DateAddedToPerson { get; set; } = DateTime.Now;
        public DateTime? DateAddedToPersonGroup { get; set; } = DateTime.Now;
        

        private byte[] _imageBytes = null;
        public byte[] ImageBytes
        {
            get
            {
                //lets build a default image for an entry. so we can 
                if (_imageBytes == null)
                {
                    _imageBytes = ImageManagement.ImageManager.GetBytesOfImage(_bmImage);
                }
                return _imageBytes;
            }
            set
            {
                _imageBytes = value;
            }
        }

        #region Not Mapped : Not in the Database
        [NotMapped]
        public Microsoft.ProjectOxford.Face.Contract.FaceAttributes Attributes
        {
            get
            {
                if (FaceAttributes != null)
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Microsoft.ProjectOxford.Face.Contract.FaceAttributes>(FaceAttributes);
                }
                else
                {
                    return null;
                }
            }
        }
        [NotMapped]
        public Microsoft.ProjectOxford.Face.Contract.FaceLandmarks Landmarks
        {
            get
            {
                if (FaceLandmarks != null)
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Microsoft.ProjectOxford.Face.Contract.FaceLandmarks>(FaceLandmarks);
                }
                else
                {
                    return null;
                }
            }
        }
        [NotMapped]
        public Microsoft.ProjectOxford.Face.Contract.FaceRectangle Rectangle => Newtonsoft.Json.JsonConvert.DeserializeObject<Microsoft.ProjectOxford.Face.Contract.FaceRectangle>(FaceRectangle);

        [NotMapped]
        public bool DrawRectangle { get; set; } = true;

        private System.Drawing.Image _bmImage = null;
        [NotMapped]
        public System.Drawing.Image BitmapImage
        {
            get
            {
                if (_bmImage == null)
                {
                    if (_imageBytes != null)
                    {
                        _bmImage = ImageManager.GetImageOfBytes(this._imageBytes);
                    }
                }
                if (DrawRectangle)
                {
                    _bmImage = ImageManager.DrawRectangleOverFaces(_bmImage, new FaceRectangle(FaceRectangle));
                }
                return _bmImage;
            }
        }

        #endregion
        public static MyFace GetMyFaceByID(Guid MyFaceSystemID)
        {
            MyFace rtnFace = null;
            using (var db = new LiveEduFaceModel())
            {
                rtnFace = db.MyFaces.Single(x => x.ID == MyFaceSystemID);
            }
            return rtnFace;
        }
    }
}