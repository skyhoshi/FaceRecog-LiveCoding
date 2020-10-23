using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ProjectOxford.Face.Contract;

namespace Face_Recognition_Debug_Application.Forms.FaceList
{
    public partial class frmShowFaceListDetails : Form
    {
        public string FaceListGuid { get; set; }
        public List<Microsoft.ProjectOxford.Face.Contract.PersonFace> LoPersonFaces = new List<PersonFace>();
        public frmShowFaceListDetails()
        {
            InitializeComponent();
        }


        public void LoadDatabase()
        {
            if (FaceListGuid == string.Empty)
            {
                MessageBox.Show("You must set the facelistGuid Property first before showing this");
                this.Close();
            }
            var i = Task.Run(async () =>
            {
                LoPersonFaces = await Facial_Recognition_Library.API.ProjectOxfordAPI.GetPersonsInFaceListByFaceListIDAsync(FaceListGuid);
            }).ContinueWith((task, o) =>
            {
                this.personFaceBindingSource.DataSource = LoPersonFaces;
                this.personFaceBindingSource.ResetBindings(false);
            }, null, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void frmShowFaceListDetails_Shown(object sender, EventArgs e)
        {
            LoadDatabase();
        }
    }
}
