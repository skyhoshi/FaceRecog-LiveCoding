using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Accord;
using Facial_Recognition_Library.API.Results;
using Facial_Recognition_Library.IO;

namespace Facial_Recognition_Library.ImageManagement
{
    public class ImageManager
    {
        /// <summary>
        /// Saves the image to the file system as a PNG format.
        /// </summary>
        /// <param name="img"></param>
        /// <param name="SavePath"></param>
        public static void SaveImageToFileSystem(System.Drawing.Image img, string SavePath)
        {
            img.Save(SavePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// Converts an Array of <see cref="byte"/> to an <see cref="System.Drawing.Image"/>
        /// </summary>
        /// <param name="img">Array of <see cref="byte"/></param>
        /// <returns></returns>
        public static System.Drawing.Image GetImageOfBytes(byte[] img)
        {
            System.Drawing.Image rtnImage = null;
            using (var ms = new MemoryStream(img))
            {
                rtnImage = new Bitmap(ms);
            }
            return rtnImage;
        }

        /// <summary>
        /// Converts Image from File System into an Array of <see cref="byte"/>
        /// </summary>
        /// <param name="ImageLocation"></param>
        /// <returns></returns>
        public static byte[] GetBytesOfImage(string ImageLocation)
        {
            System.Drawing.Image img = Image.FromFile(ImageLocation);
            return GetBytesOfImage(img);
        }

        /// <summary>
        /// Converts <see cref="System.Drawing.Image"/> to an Array of <see cref="byte"/>
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] GetBytesOfImage(System.Drawing.Image img)
        {
            if (img != null)
            {
                byte[] imgBytes = null;
                try
                {
                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, img.RawFormat);
                        imgBytes = ms.ToArray();
                    }
                }
                catch (OutOfMemoryException oome)
                {
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return imgBytes;
            }
            else
            {
                //Send in the default image for storage. Facial_Recognition_Library.Properties.Resources.default_users
                img = Facial_Recognition_Library.Properties.Resources.default_users;
                byte[] imgBytes = null;
                try
                {
                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, img.RawFormat);
                        imgBytes = ms.ToArray();
                    }
                }
                catch (OutOfMemoryException oome)
                {
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return imgBytes;
            }
        }

        #region Draw Face Rectangle Over Faces 

        /// <summary>
        /// Draws a <see cref="Microsoft.ProjectOxford.Face.Contract.FaceRectangle"/> in Aqua Blue on the Image provided. (should be the image that produced the FaceRectangle) 
        /// </summary>
        /// <param name="bmImage"><see cref="System.Drawing.Image"/></param>
        /// <param name="fr"><see cref="Microsoft.ProjectOxford.Face.Contract.FaceRectangle"/></param>
        /// <returns>Updated Image <see cref="System.Drawing.Image"/></returns>
        public static Image DrawRectangleOverFaces(Image bmImage, FaceRectangle fr)
        {
            
            return DrawRectangleOverFaces(bmImage, fr, Color.Aqua);
        }
        /// <summary>
        /// Draws a <see cref="Microsoft.ProjectOxford.Face.Contract.FaceRectangle"/> in Aqua Blue on the Image provided. (should be the image that produced the FaceRectangle)
        /// </summary>
        /// <param name="bmImage"><see cref="System.Drawing.Image"/></param>
        /// <param name="fr"><see cref="Microsoft.ProjectOxford.Face.Contract.FaceRectangle"/></param>
        /// <param name="penHexColor">Hex Value compatable with <see cref="System.Drawing.ColorTranslator.FromHtml"/></param>
        /// <returns>Updated Image <see cref="System.Drawing.Image"/></returns>
        public static Image DrawRectangleOverFaces(Image bmImage, FaceRectangle fr, string penHexColor)
        {
            Color penColor = System.Drawing.ColorTranslator.FromHtml(penHexColor);
            using (var g = Graphics.FromImage(bmImage))
            {
                Rectangle rtgl = new Rectangle(x: Convert.ToInt32(fr.Left), y: Convert.ToInt32(fr.Top), width: Convert.ToInt32(fr.Width), height: Convert.ToInt32(fr.Height));
                g.DrawRectangle(new Pen(penColor), rtgl);
                g.Save();
            }
            return bmImage;
        }
        /// <summary>
        /// Draws a <see cref="Microsoft.ProjectOxford.Face.Contract.FaceRectangle"/> in Aqua Blue on the Image provided. (should be the image that produced the FaceRectangle)
        /// </summary>
        /// <param name="bmImage"><see cref="System.Drawing.Image"/></param>
        /// <param name="fr"><see cref="System.Drawing.Color"/></param>
        /// <param name="penColor"><see cref="System.Drawing.Image"/></param>
        /// <returns>Updated Image <see cref="System.Drawing.Image"/></returns>
        public static Image DrawRectangleOverFaces(Image bmImage, FaceRectangle fr, Color penColor)
        {
            using (var g = Graphics.FromImage(bmImage))
            {
                Rectangle rtgl = new Rectangle(x: Convert.ToInt32(fr.Left), y: Convert.ToInt32(fr.Top), width: Convert.ToInt32(fr.Width), height: Convert.ToInt32(fr.Height));
                g.DrawRectangle(new Pen(penColor), rtgl);
                g.Save();
            }
            return bmImage;
        }

        #endregion
        /// <summary>
        /// Use this method when on error, save the image to the temp folder for review. 
        /// </summary>
        /// <param name="bImage"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool OutputByteArrayImageToTempDirectoryForReview(byte[] bImage, string fileName = "")
        {
            string TempDirectory = FileSystemManager.TempImageLocationForErrors;
            System.IO.Directory.CreateDirectory(TempDirectory);
            string fullPathNameWithFileName = TempDirectory + $@"{Guid.NewGuid()}.png";

            if (!string.IsNullOrWhiteSpace(fileName))
            {
                fullPathNameWithFileName = TempDirectory + fileName;
            }

            try
            {
                Image img = ImageManager.GetImageOfBytes(bImage);
                img.Save(fullPathNameWithFileName, ImageFormat.Png);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }


            return true;
        }
    }
}
