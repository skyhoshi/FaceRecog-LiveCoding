using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video;
using Accord.Video.DirectShow;
using Facial_Recognition_Library.API;
using Facial_Recognition_Library.API.Results;
using Facial_Recognition_Library.Controls;
using Facial_Recognition_Library.Data;
using Facial_Recognition_Library.Data.tbls;

namespace Face_Recognition_Debug_Application
{
    public partial class frmSimplePlayer : Form
    {
        public frmSimplePlayer()
        {
            InitializeComponent();
        }

        private Stopwatch stopWatch = null;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        // "Exit" menu item clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open local video capture device
        private void localVideoCaptureDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                VideoCaptureDevice videoSource = form.VideoDevice;

                // open it
                OpenVideoSource(videoSource);
            }
        }

        // Open video file using DirectShow
        private void openVideofileusingDirectShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // create video source
                FileVideoSource fileSource = new FileVideoSource(openFileDialog.FileName);

                // open it
                OpenVideoSource(fileSource);
            }
        }

        // Open JPEG URL
        private void openJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //URLForm form = new URLForm();

            //form.Description = "Enter URL of an updating JPEG from a web camera:";
            //form.URLs = new string[]
            //{
            //    "http://195.243.185.195/axis-cgi/jpg/image.cgi?camera=1",
            //};

            //if (form.ShowDialog(this) == DialogResult.OK)
            //{
            //    // create video source
            //    JPEGStream jpegSource = new JPEGStream(form.URL);

            //    // open it
            //    OpenVideoSource(jpegSource);
            //}
        }

        // Open MJPEG URL
        private void openMJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //URLForm form = new URLForm();

            //form.Description = "Enter URL of an MJPEG video stream:";
            //form.URLs = new string[]
            //{
            //    "http://195.243.185.195/axis-cgi/mjpg/video.cgi?camera=4",
            //    "http://195.243.185.195/axis-cgi/mjpg/video.cgi?camera=3",
            //};

            //if (form.ShowDialog(this) == DialogResult.OK)
            //{
            //    // create video source
            //    MJPEGStream mjpegSource = new MJPEGStream(form.URL);

            //    // open it
            //    OpenVideoSource(mjpegSource);
            //}
        }

        // Capture 1st display in the system
        private void capture1stDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenVideoSource(new ScreenCaptureStream(Screen.AllScreens[0].Bounds, 100));
        }

        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();

            // reset stop watch
            stopWatch = null;

            // start timer
            timer.Start();

            this.Cursor = Cursors.Default;
        }

        // Close video source if it is running
        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        // New frame received by the player
        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            DateTime now = DateTime.Now;
            Graphics g = Graphics.FromImage(image);

            // paint current time
            SolidBrush brush = new SolidBrush(Color.Red);
            g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
            brush.Dispose();

            g.Dispose();
        }

        // On timer event - gather statistics : Frames Per Second. (1000 milliseconds)
        private void timer_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if (videoSource != null)
            {
                // get number of frames since the last timer tick
                int framesReceived = videoSource.FramesReceived;

                if (stopWatch == null)
                {
                    stopWatch = new Stopwatch();
                    stopWatch.Start();
                }
                else
                {
                    stopWatch.Stop();

                    float fps = 1000.0f * framesReceived / stopWatch.ElapsedMilliseconds;
                    fpsLabel.Text = fps.ToString("F2") + " fps";

                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }

        private void getStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #region "Facial Recognition"

        /// <summary>
        /// Saves the current frame to the file system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void takePictureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer.IsRunning)
            {
                Bitmap MyCurrentImage = videoSourcePlayer.GetCurrentVideoFrame();
                Facial_Recognition_Library.ImageManagement.ImageManager.SaveImageToFileSystem(MyCurrentImage, $@"W:\img.png");
            }
            else
            {
                tsSLErrors.Text = "You must first start the camera before taking a picture.";
                tsSLErrors.Visible = true;
            }
        }

        /// <summary>
        /// Saves the current frame to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savePictureToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer.IsRunning)
            {
                Bitmap MyCurrentImage = videoSourcePlayer.GetCurrentVideoFrame();
                Facial_Recognition_Library.ImageManagement.ImageManager.SaveImageToFileSystem(MyCurrentImage, $@"W:\img.png");
                // we want to create a new dialog for entry of information associated with the face. 
                frmFaceAttributes fa = new frmFaceAttributes(AddInformationToNewImage: true);
                fa.ShowDialog();
            }
            else
            {
                tsSLErrors.Text = "You must first start the camera before taking a picture.";
                tsSLErrors.Visible = true;
            }

        }

        /// <summary>
        /// Sends the current frame to the API and saves the image and the response to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendPictureToAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        /// <summary>
        /// Timer used to display notifications: every 10 seconds the status bars are cleared (except for framerate)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrNotifications_Tick(object sender, EventArgs e)
        {
            tsSLErrors.Text = "";
            tsSLErrors.Visible = false;
        }
        /// <summary>
        /// Process the image using the CognitiveServiceAPI Class: (Direct HTTP client interface manamgent 
        /// </summary>
        /// <param name="MyCurrentImage"></param>
        /// <param name="saveLocal"></param>
        private void ProcessImage(Image MyCurrentImage, bool saveLocal = false)
        {
            if (saveLocal)
            {
                MyCurrentImage.Save($@"W:\Example Pictures\MyImage{DateTime.Now.ToFileTime()}.png", ImageFormat.Png);
            }
            //ImageType.Text = Enum.GetName(typeof(System.Drawing.Imaging.ImageFormat), MyCurrentImage.RawFormat);
            using (MemoryStream ms = new MemoryStream())
            {
                MyCurrentImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Facial_Recognition_Library.API.CognitiveServiceAPI serviceApi = new CognitiveServiceAPI();
                //Settings
                serviceApi.ThrowErrorToParent = true;

                //There are several ways of doing this, and all have direct relationship to how much control you want to have.
                //Thus, this is the simplest and most convient method where in you are given just what you need to complete the task.
                //using (HttpClient hcClient = new HttpClient())
                HttpClient hcClient = new HttpClient();
                List<FaceDetectFaceResult> FaceDetectResult = new List<FaceDetectFaceResult>();
                try
                {
                    FaceDetectResult = serviceApi.GetFaceDetectResult(ms, ref hcClient);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                try
                {
                    if (FaceDetectResult?.Count > 0)
                        foreach (var face in FaceDetectResult)
                        {
                            //Do Something
                            MyFace newface = new MyFace
                            {
                                FaceID = Guid.Parse(face.FaceId),
                                FaceAttributes = face.getJsonFaceAttibutes(),
                                FaceLandmarks = face.getJsonFaceLandmarks(),
                                FaceRectangle = face.getJsonFaceRectangle(),
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
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    //throw e;
                }
            }
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaceDBData frmdata = new frmFaceDBData();
            frmdata.Show();
        }

        private void getNewImageFromUSBToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (videoSourcePlayer.IsRunning)
            {
                Bitmap MyCurrentImage = videoSourcePlayer.GetCurrentVideoFrame();
                ProcessImage(MyCurrentImage, true);
            }
            else
            {
                MessageBox.Show("Turn your camera on first please.");
            }
        }

        public object state { get; set; }

        private void loadAndProcessImageFromFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = this.ofdLoadExsitingImage.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    Image MyCurrentImage = Image.FromFile(ofdLoadExsitingImage.FileName);
                    this.tsSLErrors.Text = "Starting....";
                    var i = Task.Run(() =>
                    {
                        //state = "Starting....";
                        ProcessImage(MyCurrentImage);
                        //state = "Complete";
                    }).ContinueWith((task, o) =>
                    {
                        this.tsSLErrors.Text = "Completed....";
                    }, state: state, scheduler: TaskScheduler.FromCurrentSynchronizationContext());

                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
