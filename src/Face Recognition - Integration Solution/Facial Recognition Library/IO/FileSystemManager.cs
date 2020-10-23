using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Facial_Recognition_Library.IO
{
    public static class FileSystemManager
    {
        public static string TempImageLocationForErrors { get; set; } = AppContext.BaseDirectory + $@"\TempImagesAssociatedWithErrors\";

        public static string TempImageLocation
        {
            get
            {
                System.IO.Directory.CreateDirectory(_tempImageLocation);
                return _tempImageLocation;
            }
            set => _tempImageLocation = value;
        }
        private static string _tempImageLocation = AppContext.BaseDirectory + $@"\TempImageStorageForProcessing\";

        public static void ApplicaitonExitCleanup()
        {
            int ProcessID = Process.GetCurrentProcess().Id;
            System.Diagnostics.Debug.WriteLine($"Process ID: {ProcessID}");
            //perform application temp cleanup 
            //Take all images within the temp folder and move them to the process ID labeled folder
            if (System.IO.Directory.Exists(FileSystemManager.TempImageLocationForErrors))
            {
                IEnumerable<string> loErrorPng = System.IO.Directory.EnumerateFiles(FileSystemManager.TempImageLocationForErrors, "*.png", SearchOption.TopDirectoryOnly);
                IEnumerable<string> loPreviousRuns = System.IO.Directory.EnumerateDirectories(FileSystemManager.TempImageLocationForErrors, "*", SearchOption.TopDirectoryOnly);
                string nextFolderName;
                //Move temp images into process ID folder for archival puposes. 
                IEnumerable<string> previousRuns = loPreviousRuns.ToList();
                if (previousRuns.Contains($"{ProcessID}"))
                {
                    var loPreviousRunsWithSameProcessId = previousRuns.Count(x => x.Contains($"{ProcessID}"));
                    nextFolderName = $"{ProcessID}-{loPreviousRunsWithSameProcessId + 1}";
                }
                else
                {
                    nextFolderName = $"{ProcessID}";
                }

                string processFolder = TempImageLocationForErrors + nextFolderName;
                try
                {
                    System.IO.Directory.CreateDirectory(processFolder);
                }
                catch (Exception e)
                {
                    throw e;
                }

                FileInfo fileInfo = null;
                foreach (string filePng in loErrorPng.ToList())
                {
                    fileInfo = new FileInfo(filePng);
                    string newFile = $@"{processFolder}\{fileInfo.Name}";
                    System.Diagnostics.Debug.WriteLine($"{newFile}");
                    fileInfo.MoveTo(newFile);
                    fileInfo = null;
                }
                fileInfo = null;
            }
            //TODO: Add review of folders already in dump area. to allow cleanup. 
            //you may want to add a size assessment, or Age assessment with thresholds to allow cleanup of existing folders.


            //Cleanup Temp storage directory ( Non-Errors )
            if (System.IO.Directory.Exists(FileSystemManager.TempImageLocation)) System.IO.Directory.Delete(FileSystemManager.TempImageLocation, true);
        }
    }
}
