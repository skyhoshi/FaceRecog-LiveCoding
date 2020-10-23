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
using System.Collections;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading;
using Face_Recognition_Debug_Application.Forms.FaceList;
using Face_Recognition_Debug_Application.Forms.Person;
using Face_Recognition_Debug_Application.Forms.PersonGroup;
using Facial_Recognition_Library.API;
using Facial_Recognition_Library.API.Results;
using Facial_Recognition_Library.Controls;
using Facial_Recognition_Library.Data.tbls;
using Microsoft.ProjectOxford.Face.Contract;
using FaceRectangle = Microsoft.ProjectOxford.Face.Contract.FaceRectangle;
using static Facial_Recognition_Library.Controls.DataGridViewUtilities;
//TODO: Redo all Async processes to use Async Properly : Full Net Framework Async

namespace Face_Recognition_Debug_Application
{
    /// <inheritdoc />
    public partial class frmFaceDBData : PrimaryForm
    {
        private readonly SynchronizationContext SyncContext;
        private const string strBaseStatusMessage = "Current Status : Ready(Not used in all situations)";

        //public System.Windows.Forms.BindingSource APIFaceListMetadataBindingSource;
        //internal System.Windows.Forms.BindingSource APIPersonGroupBindingSource;
        //internal System.Windows.Forms.BindingSource APIPersonBindingSource;

        #region Property Objects : Lists Of Objects
        #region Database Properties
        #region BackingFields
        private static List<MyFace> _loDatabaseFaces = null;
        private static List<MyFaceList> _loDatabaseFaceLists = null;
        private static List<MyPersonGroup> _loDabasePersonGroups = null;
        private static List<MyPerson> _loDatabasePersons = null;
        #endregion

        public List<MyFace> loDatabaseFaces
        {
            get { return _loDatabaseFaces; }
            set { _loDatabaseFaces = value; }
        }

        public List<MyFaceList> loDatabaseFaceLists
        {
            get { return _loDatabaseFaceLists; }
            set { _loDatabaseFaceLists = value; }
        }

        public List<MyPersonGroup> loDabasePersonGroups
        {
            get { return _loDabasePersonGroups; }
            set { _loDabasePersonGroups = value; }
        }

        public List<MyPerson> loDatabasePersons
        {
            get { return _loDatabasePersons; }
            set { _loDatabasePersons = value; }
        }

        #endregion
        //#region Properties : List of API Objects

        //#endregion
        #endregion

        #region Form Events
        public frmFaceDBData()
        {
            InitializeComponent();

            SyncContext = SynchronizationContext.Current;

            this.DataFormRefresh += OnDataFormRefresh;
            this.DataApiFormRefresh += OnDataApiFormRefresh;
            this.DataAllFormRefresh += OnDataAllFormRefresh;
        }

        private void OnDataAllFormRefresh()
        {
            Task.Run(async () => { await LoadAllDatasources(); });
        }

        private void OnDataApiFormRefresh()
        {
            Task.Run(async () => { await LoadAllAPI(); });
        }

        private void OnDataFormRefresh()
        {
            Task.Run(async () =>
            {
                await LoadAllDatabase();
                toolStripStatusLabel1.Text = strBaseStatusMessage; //$@"";
            });

        }

        private async void frmFaceDBData_Load(object sender, EventArgs e)
        {
            await LoadDatabaseFaces();
            await LoadDatabaseFaceLists();
        }


        #endregion

        #region Tab Control Events

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Go through and hide all the non-applicable 
        }

        #endregion
        #region Toolbar Events
        private void reviewAllAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Move to Library : reviewAllAttributesToolStripMenuItem_Click :  method contents can be moved to library to facilitate code reuse.
            var DataRows = this.dgvImagesInDb.SelectedRows;
            DataGridViewRow dr = null;
            if (DataRows.Count > 0)
            {
                dr = DataRows[0];
            }
            if (dr == null)
            {
                var rowIndex = this.dgvImagesInDb.SelectedCells[0].RowIndex;
                dr = this.dgvImagesInDb.Rows[rowIndex];
            }
            string strfaceSystemID = dr.Cells[1].Value.ToString();
            string strfaceAttributes = dr.Cells[3].Value.ToString();

            frmFaceAttributes frmFA = new frmFaceAttributes(Guid.Parse(strfaceSystemID), strfaceAttributes);
            frmFA.ShowDialog();
        }

        private void encodeStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEncodeServiceKey frmESK = new frmEncodeServiceKey();
            frmESK.ShowDialog();
        }

        private async void refreshDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadDatabaseFaces();
            await LoadDatabaseFaceLists();
        }

        private async void refreshApiListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadAPIFaceList();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCameraInterface = new frmSimplePlayer();
            frmCameraInterface.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenus.OpenImgFromFileSystem(ref sender, e);
        }

        #region Face Menu Items
        private void enterFaceIntoDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuProcessResult result = ToolStripMenus.CreateNewFaceEntryInDatabase(ref sender, e);
            var frmCameraInterface = new frmSimplePlayer();
            frmCameraInterface.ShowDialog();
        }
        #endregion

        #region FaceList Menu Items

        private bool OpenfrmCreateNewFaceList(frmCreateNewFaceList frmCreateNewFaceList)
        {
            frmCreateNewFaceList.ShowDialog();
            switch (frmCreateNewFaceList.Result)
            {
                case DialogResult.None:
                    MessageBox.Show($"There was an error in attempting to create your list. Please review the info provided and try again.  {frmCreateNewFaceList.Exception?.Message}", "There was an Error", MessageBoxButtons.OK);
                    OpenfrmCreateNewFaceList(frmCreateNewFaceList);
                    break;
                case DialogResult.Cancel:
                    return false;
                    break;
                default:
                    break;
            }
            return true;
        }

        private void deleteFaceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //This method detects if the correct tab is display'd if it is not, then it ignores the button press with a status message. 
        }

        /// <summary>
        /// Causes both Data Grid Views to be refreshed and polished for use. 
        /// </summary>
        /// <param name="sender">Refresh Face List <see cref="ToolStripMenuItem"></see></param>
        /// <param name="e"></param>
        private async void refreshFaceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //This method detects if the correct tab is display'd if it is not, then it ignores the button press with a status message. 
            //Refreshes the corrisponding list. 
            await LoadDatabaseFaceLists();
            await LoadAPIFaceList();
        }

        private async void createNewFaceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Move this to the libary : createNewFaceListToolStripMenuItem_Click
            Guid FaceListID = Guid.Empty;
            using (var db = new LiveEduFaceModel())
            {
                var myfaceList = new MyFaceList(); //db.MyFaceLists.Create();
                db.MyFaceLists.Add(myfaceList);
                db.SaveChanges();
                FaceListID = myfaceList.ID;
                frmCreateNewFaceList frmCreateNewFaceList = new frmCreateNewFaceList(FaceListID);
                bool Successful = OpenfrmCreateNewFaceList(frmCreateNewFaceList);
                if (Successful)
                {
                    myfaceList.FaceListId = frmCreateNewFaceList.FaceListID;
                    myfaceList.Name = frmCreateNewFaceList.FaceListName;
                    myfaceList.UserData = frmCreateNewFaceList.FaceListUserData;
                    if (myfaceList.UserData != FaceListID.ToString())
                    {
                        //Throw an error??
                    }
                }
                else
                {
                    //Clean up the DB due to Error or cancelation
                    db.MyFaceLists.Remove(myfaceList);
                }
                db.SaveChanges();
            }
            await LoadDatabaseFaceLists();
            await LoadAPIFaceList();
        }
        #endregion


        #region PersonGroups Menu Items
        private async void refreshPersonGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadAPIPersonGroup();
        }

        private async void createPersonGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonGroup frmPersonGroup = new frmPersonGroup();
            var personGroupDialogResult = frmPersonGroup.ShowDialog();
            if (personGroupDialogResult == DialogResult.OK)
            {
                string strPersonGroupName = frmPersonGroup.strPersonGroupName;
                string strPersonGroupID = frmPersonGroup.strPersonGroupID;
                frmPersonGroup = null;
                var CreateResult = await Facial_Recognition_Library.Data.fnc.PersonGroup.CreatePersonGroup(strPersonGroupName, strPersonGroupID);
                if (CreateResult.CompletedAPIOperation && CreateResult.CompletedDatabaseOperation)
                {
                    await LoadDatabasePersonGroups();
                    await LoadAPIPersonGroup();
                }
                else
                {
                    MessageBox.Show($@"Your attempted to add a person group failed : {CreateResult.ReasonForFailure}");
                }
            }
        }

        private void deletePersonGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This method detects if the correct tab is display'd if it is not, then it ignores the button press with a status message. 

        }
        #endregion

        #region Person Menu Items
        private void refreshPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }

        private async void createPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //TODO: This method detects if the correct tab is display'd if it is not, then it ignores the button press with a status message. 
            //User Should start out either in the Faces DB Tab or in a new Face Window. 
            frmPerson frmPerson = new frmPerson();
            var personGroupDialogResult = frmPerson.ShowDialog();
            if (personGroupDialogResult == DialogResult.OK)
            {
                string strPersonName = frmPerson.strPersonName;
                string strPersonGroupId = frmPerson.strPersonGroupId;
                frmPerson = null;
                var CreateResult = await Facial_Recognition_Library.Data.fnc.Person.CreatePerson(strPersonGroupId, strPersonName);
                if (CreateResult.CompletedAPIOperation && CreateResult.CompletedDatabaseOperation)
                {
                    await LoadDatabasePersonGroups();
                    await LoadAPIPersonGroup();
                }
                else
                {
                    MessageBox.Show($@"Your attempted to add a person group failed : {CreateResult.ReasonForFailure}");
                }
            }

        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //This method detects if the correct tab is display'd if it is not, then it ignores the button press with a status message. 
        }
        #endregion

        #region Face - Comparing Faces Methods
        private void findSimilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            //1. Go to List of Image in "Images of Faces"
            //2. Select a row
            //3. Click "Find Similar"
            //Check that a face has been selected
            if (IsARowSelected(dgvImagesInDb, out System.Windows.Forms.DataGridViewRow SelectedRow))
            {

                //4. Check for FaceListId Association
                //4. A. If None - Request Association via frmFaceAssocation 
                //5. retrieve Face ID
                //5. A. If FaceID is old (24 hours >) ReDetect and update FaceID
                //5. A. 1. Take Image and resend to Face Detect API
                //6. Ask for FaceList to compare against frmFaceList
                //7. Send request to API For "Find Similar"
                //8. Output Results to frmFindSimilarResults
            }
        }


        private void GroupFacesFromListOfFacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //1. Go to List of Image in "Images of Faces"
            //2. Select a row
            //3. Click "Validate Face is in List of Faces"
            //4. Check for FaceListId Association
            //4. A. If None - Request Association via frmFaceAssocation 
            //5. retrieve Face ID
            //5. A. If FaceID is old (24 hours >) ReDetect and update FaceID
            //5. A. 1. Take Image and resend to Face Detect API
            //6. Ask for FaceList to compare against frmFaceList
            //7. Send request to API For "Find Similar"
            //8. Output Results to frmFindSimilarResults
        }

        #endregion

        #region Person - Comparing Groups of Persons / Faces (as person)
        private void verifyFaceBelongsToAPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            //1. Go to List of Image in "Images of Faces"
            //2. Select a row
            //3. Click "Verify Face belongs to a Person"
            //NOTE: you can loop through your person groups to find the person this face belongs to. COSTS ALOT OF API CALLS. (one for each person in the api) 
            //4. Get Person Group ID
            //5. Get Person ID To compare to
            //6. Compare
        }
        #endregion

        private async void refreshAllDataItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadAllDatasources();
            await LoadAPIPersons();
            await LoadAPIPersonGroup();
            //throw new NotImplementedException();
            //Create a Message Box that displays' "Please wait"
            //Show the message box
            //Load the data in a seperate thread
            //on completion of the thread. hide the message box.
        }


        private void identifyFaceAmongAPersonGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //1. Select Face from Database "Images of Faces"
            //2. Get FaceID
            //3. Ask for Person Group ID from frmPickFromList (List(Of MyPersonGroups))
            //4. Display the results on frmIdentifyResults
        }

        #endregion

        #region DataGridView Events
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dgvFaceAPIFaceLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Take the Column for the event and pass the column to the processor
            DataGridViewColumn dgvc = ((DataGridView)sender).Columns[e.ColumnIndex];
            //Process Data Grid View
            await Task.Run(() =>
             {
                 var result = DataGridViews.DgvFaceApiFaceLists(ref sender, e, dgvc);
                 if (result != null)
                 {
                     ProcessDataGridViewResult(result);
                 }
             });
            //this.DataGridViewsHandler.dgvFaceAPIFaceLists(ref sender, e, dgvc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dgvFaceListInDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Take the Column for the event and pass the column to the processor
            DataGridViewColumn dgvc = ((DataGridView)sender).Columns[e.ColumnIndex];
            toolStripStatusLabel1.Text = $@"Current Status: Starting Face Data Update.";

            await Task.Run(() =>
            {
                //Process Data Grid View
                var result = DataGridViews.DgvFaceApiFaceLists(ref sender, e, dgvc);
                if (result != null)
                {
                    ProcessDataGridViewResult(result);
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dgvImagesInDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            toolStripStatusLabel1.Text = $@"Current Status: Starting Images Within Database Update.";
            await Task.Run(() =>
            {
                if (DataGridViews.ValidateRowSelected(ref sender, e))
                {
                    //Take the Column for the event and pass the column to the processor
                    if (e.ColumnIndex > -1)
                    {
                        DataGridViewColumn dgvc = ((DataGridView)sender).Columns[e.ColumnIndex];
                        //Facial_Recognition_Library.Controls.DataGridViews.dgvImagesInDb(ref sender, e, dgvc);
                        var result = DataGridViews.DgvImagesInDb(ref sender, e, dgvc);
                        if (result != null)
                        {
                            ProcessDataGridViewResult(result);
                        }
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($@"No Row Selected.");
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dgvPersonGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViews.ValidateRowSelected(ref sender, e))
            {
                //TODO: Create Process to handle buttons within grid view. 
                //if (e.RowIndex < 0 || e.ColumnIndex != dgvFaceAPIFaceLists.Columns[dgvFaceAPIFaceLists.Columns.Count - 1].Index) return;
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == dgvPersonGroups?.Columns[dgvbtnDeletePersonGroup.Name]?.Index)
                {
                    int? PersonGroupIdColumnIndex = dgvPersonGroups?.Columns[personGroupIdDataGridViewTextBoxColumn.Name]?.Index;
                    if (PersonGroupIdColumnIndex.HasValue)
                    {
                        string strPersonGroupID = (string)dgvPersonGroups[PersonGroupIdColumnIndex.Value, e.RowIndex].Value;
                        var status = await Facial_Recognition_Library.Data.fnc.PersonGroup.DeletePersonGroup(strPersonGroupID);
                        if (status.CompletedAPIOperation && status.CompletedDatabaseOperation)
                        {
                            await LoadDatabasePersonGroups();
                            await LoadAPIPersonGroup();
                        }
                        else
                        {
                            MessageBox.Show(status.ReasonForFailure);
                        }
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($@"No Row Selected.");
                }
            }

        }
        #endregion


        #region Button Events

        private async void btnRetrieveFaceListFromAPI_Click(object sender, EventArgs e)
        {
            await LoadAPIFaceList();
        }

        #endregion


        #region Private Methods - Load Data Sources
        private async Task LoadAllDatasources()
        {
            await LoadAllDatabase();
            await LoadAllAPI();
        }

        private async Task LoadAllDatabase()
        {
            await LoadDatabaseFaces();
            await LoadDatabaseFaceLists();
            await LoadDatabasePersons();
            await LoadDatabasePersonGroups();
        }

        private async Task LoadAllAPI()
        {
            await LoadAPIPersons();
            await LoadAPIPersonGroup();
            await LoadAPIFaceList();
            //await Task.Run(() =>{}).ContinueWith((task, o) =>{}, null, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async Task LoadDatabasePersons()
        {
            //await Task.Run(async () =>
            //{
            using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
            {
                loDatabasePersons = await db.MyPersons.ToListAsync();
            }
            //}).ContinueWith((task, o) =>
            //{
            SyncContext.Post(new SendOrPostCallback(o =>
            {
                DatabasePersonBindingSource.DataSource = loDatabasePersons;
                DatabasePersonBindingSource.ResetBindings(false);
            }), null);
            //}, null, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async Task LoadDatabasePersonGroups()
        {
            //await Task.Run(async () =>
            //{
            using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
            {
                loDabasePersonGroups = await db.MyPersonGroups.ToListAsync();
            }
            //}).ContinueWith((task, o) =>
            //{
            SyncContext.Post(new SendOrPostCallback(o =>
            {
                DatabasePersonGroupBindingSource.DataSource = loDabasePersonGroups;
                DatabasePersonGroupBindingSource.ResetBindings(false);
            }), null);
            //}, null, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async Task LoadDatabaseFaces()
        {
            //await Task.Run(() =>
            // {
            using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
            {
                loDatabaseFaces = await db.MyFaces.ToListAsync();
            }
            // }).ContinueWith((task, o) =>
            // {
            SyncContext.Post(new SendOrPostCallback(o =>
            {
                UpdateMyFacesBindingSource();
            }), null);
            // }, null, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async Task LoadDatabaseFaceLists()
        {
            // await Task.Run(() =>
            //{
            using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
            {
                loDatabaseFaceLists = await db.MyFaceLists.ToListAsync();
            }
            //}).ContinueWith((task, o) =>
            //{
            SyncContext.Post(new SendOrPostCallback(o =>
            {
                this.DatabaseFaceListBindingSource.DataSource = _loDatabaseFaceLists;
                this.DatabaseFaceListBindingSource.ResetBindings(false);
            }), null);
            //}, null, TaskScheduler.FromCurrentSynchronizationContext());
        }


        private async Task LoadAPIFaceList()
        {
            //Example of inline await calling. IL is the same as LoadAPIPersonGroup
            this.APIFaceListMetadataBindingSource.DataSource = (await ProjectOxfordAPI.GetAllFaceLists()).ToList();
        }

        private async Task LoadAPIPersonGroup()
        {
            var loPersonGroups = await ProjectOxfordAPI.GetAllPersonGroups();
            this.APIPersonGroupBindingSource.DataSource = loPersonGroups.ToList();
        }

        private async Task LoadAPIPersons()
        {
            var loPersons = await ProjectOxfordAPI.GetAllPersonsFromAllPersonGroups();
            this.APIPersonBindingSource.DataSource = loPersons.ToList();
        }

        private async Task LoadPersons()
        {
            await LoadDatabasePersons();
            await LoadAPIPersons();
        }

        private async Task LoadPersonGroups()
        {
            await LoadAPIPersonGroup();
            await LoadDatabasePersonGroups();
        }

        public void UpdateMyFacesBindingSource()
        {
            this.DatabaseFaceBindingSource.SuspendBinding();
            this.DatabaseFaceBindingSource.DataSource = _loDatabaseFaces;
            this.DatabaseFaceBindingSource.ResetBindings(false);
            this.DatabaseFaceBindingSource.ResumeBinding();
        }


        #endregion


    }
}
