using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Recognition_Debug_Application
{
    public partial class frmCreateNewFaceList : Form
    {
        public frmCreateNewFaceList()
        {
            InitializeComponent();
        }

        public frmCreateNewFaceList(Guid fldrid)
        {
            InitializeComponent();
            this.FaceListDatabaseRowID = fldrid;
        }

        public Guid FaceListDatabaseRowID { get; set; }
        public DialogResult Result { get; set; }
        public Exception Exception { get; set; }
        public string FaceListID { get; set; }
        public string FaceListName { get; set; }
        public string FaceListUserData { get; set; }

        private async void btnCreateFaceList_Click(object sender, EventArgs e)
        {
            FaceListID = txtFaceListID.Text;
            FaceListName = txtFaceListName.Text;
            FaceListUserData = txtFaceUserData.Text;
            FaceListUserData = FaceListDatabaseRowID.ToString();
            try
            {
                var Success = await Facial_Recognition_Library.API.ProjectOxfordAPI.CreateFaceList(FaceListID, FaceListName, FaceListUserData);
                if (Success)
                {
                    Result = DialogResult.OK;
                    this.Hide();
                    return;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Exception = ex.InnerException;
                }
                else
                {
                    Exception = ex;
                }
                Result = DialogResult.None;
                this.Hide();
            }
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
        }
    }
}
