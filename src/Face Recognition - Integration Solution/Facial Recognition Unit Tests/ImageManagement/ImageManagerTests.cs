using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facial_Recognition_Library.ImageManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facial_Recognition_Library.ImageManagement.Tests
{
    [TestClass()]
    public class ImageManagerTests
    {
        private byte[] byteArrayImage = null;

        [TestMethod()]
        public void OutputByteArrayImageToTempDirectoryForReviewTest()
        {
            string TestImageLocation = $@"W:\Example Pictures\MyImage.png";
            byteArrayImage = Facial_Recognition_Library.ImageManagement.ImageManager.GetBytesOfImage(TestImageLocation);
            if (!Facial_Recognition_Library.ImageManagement.ImageManager.OutputByteArrayImageToTempDirectoryForReview(byteArrayImage))
            {
                Assert.Fail($"Failed to output image, check Exceptions for reasons.");
            }
        }
    }
}