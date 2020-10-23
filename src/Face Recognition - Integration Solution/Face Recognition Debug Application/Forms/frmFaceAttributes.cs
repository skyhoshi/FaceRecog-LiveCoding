using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facial_Recognition_Library.Data;
using Facial_Recognition_Library.Data.tbls;

namespace Face_Recognition_Debug_Application
{
    public partial class frmFaceAttributes : Form
    {

        //public class FaceChangedArgs
        //{
        //    public FaceChangedArgs(MyFace newFace)
        //    {
        //        this.newFace = newFace ?? throw new ArgumentNullException(nameof(newFace));
        //    }

        //    public MyFace newFace { get; set; }
        //}

        //public delegate void FaceChanged(object sender, FaceChangedArgs e);

        //public event FaceChanged FaceChangedEvent;
        //private void OnFaceChangedEvent(object sender, FaceChangedArgs faceChangedArgs)
        //{
        //    this.lblSystemID.Text = faceChangedArgs.newFace.ID.ToJSON();
        //}

        private MyFace _face = null;
        public MyFace Face
        {
            get { return _face; }
            set
            {
                _face = value;
                
            }
        }

        public string FaceAttributes { get; set; }
        public frmFaceAttributes()
        {
            InitializeComponent();
            this.Close();
        }

        public frmFaceAttributes(bool AddInformationToNewImage)
        {
            InitializeComponent();
            if (!AddInformationToNewImage)
            {
                this.Hide();
            }
        }

        public frmFaceAttributes(Guid FaceSystemID, string FaceAttributes = null)
        {
            ///this.FaceChangedEvent += OnFaceChangedEvent;
            if (FaceAttributes != null)
            {
                this.FaceAttributes = FaceAttributes;
            }
            else
            {
                Face = MyFace.GetMyFaceByID(FaceSystemID);
            }
            InitializeComponent();
        }


        private void frmFaceAttributes_Load(object sender, EventArgs e)
        {
            
        }


    }
}
