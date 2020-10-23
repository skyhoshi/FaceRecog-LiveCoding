using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facial_Recognition_Library.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Facial_Recognition_Library.IO.Tests
{
    [TestClass()]
    public class FileSystemManagerTests
    {

        [TestMethod()]
        public void ApplicaitonExitCleanupTest()
        {
            //TODO: Finsih the "ApplicationExitCleanupTest" Test as it's not finished. 
            try
            {
                (new ImageManagement.Tests.ImageManagerTests()).OutputByteArrayImageToTempDirectoryForReviewTest();
                CodeAccessPermission.RevertAssert();
            }
            catch (Exception e)
            {
                
            }
            FileSystemManager.ApplicaitonExitCleanup();
        }
    }
}