

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Facial_Recognition_Library.Data;

namespace Facial_Recognition_Library.Controls
{
    using System;
    using System.Windows.Forms;
    using Facial_Recognition_Library.API;

    /// <summary>
    /// Holds all Data Grid View Event Handlers: Each click is passed to the appropreate Data Grid Handler based on the Name of the Grid View.
    /// Each Handler should return <see cref="Facial_Recognition_Library.Controls.DataGridViewsProcessResult"/> where the results are set according to what the data Form should do.
    /// </summary>
    public class DataGridViews : DataGridViewMethods
    {

        #region Data Grid View Validation Methods

        public static bool Validate_FaceList_SystemID()
        {
            return false;
        }

        #region Data Grid View Validation Methods -  Row Related
        public static bool ValidateRowSelected(ref object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex}");
            if (e.RowIndex < 0)
            {
                System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex} just Exiting method. there's no handler for this execution method.");
                return false;
            }
            return true;
        }
        public static bool ValidateColumnEntered(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn column, Type ExpectedType)
        {
            System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex}");
            if (e.ColumnIndex < 0)
            {
                System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex} just Exiting method. there's no handler for this execution method.");
                return false;
            }


            return true;
        }
        #endregion

        #endregion


        #region Data Grid Views
        /// <summary>
        /// Event handlers for the Data Grid View "FaceAPI - FaceList"
        /// </summary>
        /// <param name="sender">dgvFaceAPIFaceLists</param>
        /// <param name="e"></param>
        /// <param name="Column">Column of the event thats being fired</param>
        /// <returns></returns>
        /// <remarks>
        /// There's two ways to go about handling these events, one you can take the column and look it up. 
        ///                     OR 
        /// you can use the <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> Column Index to lookup the control <seealso cref="Facial_Recognition_Library.Controls.DataGridViewMethods"/>
        /// </remarks>
        public static DataGridViewsProcessResult DgvFaceApiFaceLists(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn Column)
        {
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();
            if (sender is DataGridView dgvFaceApiFaceLists)
            {
                if (Column != null)
                {
                    if (e.RowIndex < 0)
                    {
                        methodResult.Success = false;
                        methodResult.Reason = $"the Select Row is < 0 [No Row Selected]";
                        return methodResult;
                    }
                    //NAME: Delete Face List By Face List ID
                    if (e.ColumnIndex == dgvFaceApiFaceLists.Columns[Column.Name]?.Index)
                    {
                        //TODO: Fix this becasue it doesn't lookup the value by column Index properly we want it to mimic the index lookup from the line above.
                        string FaceListID = (string)dgvFaceApiFaceLists[0, e.RowIndex].Value;
                        var concent = MessageBox.Show($@"Are you sure you want to delete {FaceListID.ToString()} from the DB and API?", $@"Remove Face List", MessageBoxButtons.OKCancel);
                        if (concent == DialogResult.OK)
                        {
                            bool Success = ProjectOxfordAPI.DeleteFaceListByFaceListID(FaceListID).Result;
                            if (Success)
                            {
                                //LoadAPIFaceList();
                                methodResult.Success = true;
                                methodResult.ShouldRefreshAPIDataGrids = false;
                                methodResult.ShouldRefreshDatabaseDataGrids = true;
                                throw new NotImplementedException();
                            }
                        }
                    }
                    //NAME: Show Face Details
                    else if (e.ColumnIndex == dgvFaceApiFaceLists.Columns[Column.Name]?.Index)
                    {
                        throw new NotImplementedException();
                        //frmShowFaceListDetails frmShowFaceList = new frmShowFaceListDetails();
                        //frmShowFaceList.FaceListGuid = dgvFaceAPIFaceLists[0, e.RowIndex].Value.ToString();
                        //frmShowFaceList.ShowDialog();
                    }
                    //NAME: Catch all for : FaceAPI - Face Lists
                    else
                    {
                        //do nothing:)
                        System.Diagnostics.Debug.WriteLine($"Data Grid View Handler : Face API Face List was called but the click was not handled.");
                    }
                }
            }

            return methodResult;
        }

        /// <summary>
        /// Event handlers for the Data Grid View "Images In DB"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="Column"></param>
        /// <param name="DataGridViewColumns"></param>
        /// <exception cref="Facial_Recognition_Library.Controls.DataGridViewsFaceDetectException">This is thrown with an image contains more than one face. We cannot register a face when more than one is within the image.</exception>
        /// <returns></returns>
        public static DataGridViewsProcessResult DgvImagesInDb(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn Column, params DataGridViewColumn[] DataGridViewColumns)
        {
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();
            if (sender is DataGridView dgvImagesInDb)
            {
                if (Column != null)
                {
                    //Gather the data needed to process the method form the "DataGridView" (sender)

                    DataGridViewColumn SystemIDdgvtxtColumn = null;
                    DataGridViewColumn faceRectangleDataGridViewTextBoxColumn = null;
                    DataGridViewColumn imageBytesDataGridViewImageColumn = null;

                    bool GridViewColumnsInitialized = false;
                    if (DataGridViewColumns?.Length > 0)
                    {
                        try
                        {
                            SystemIDdgvtxtColumn = DataGridViewColumns.First(dgvc => dgvc.Name == "SystemIDdgvtxtColumn");
                            faceRectangleDataGridViewTextBoxColumn = DataGridViewColumns.First(dgvc => dgvc.Name == "faceRectangleDataGridViewTextBoxColumn");
                            imageBytesDataGridViewImageColumn = DataGridViewColumns.First(dgvc => dgvc.Name == "imageBytesDataGridViewImageColumn");
                            GridViewColumnsInitialized = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex);
                            System.Diagnostics.Debug.WriteLine($"Failed to retrieve the columns for data retrieval.");
                            methodResult.Success = false;
                        }
                    }
                    else
                    {
                        SystemIDdgvtxtColumn = dgvImagesInDb.Columns.OfType<DataGridViewColumn>()?.First(dgvc => dgvc.Name == "SystemIdDataGridViewTextBoxColumn");
                        faceRectangleDataGridViewTextBoxColumn = dgvImagesInDb.Columns.OfType<DataGridViewColumn>()?.First(dgvc => dgvc.Name == "rectangleDataGridViewTextBoxColumn");
                        imageBytesDataGridViewImageColumn = dgvImagesInDb.Columns.OfType<DataGridViewColumn>()?.First(dgvc => dgvc.Name == "dataGridViewImageColumn2");
                    }

                    //Providing this style of Index lookup allows the Columns to be moved around. so the function stays the same
                    //NAME: Detect Face
                    if (e.ColumnIndex == dgvImagesInDb.Columns[Column.Name]?.Index)
                    {
                        System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex}");
                        if (SystemIDdgvtxtColumn == null || faceRectangleDataGridViewTextBoxColumn == null || imageBytesDataGridViewImageColumn == null) return methodResult;
                        Guid faceSystemId = new Guid(dgvImagesInDb[SystemIDdgvtxtColumn.Index, e.RowIndex].Value.ToString());
                        string rectangle = dgvImagesInDb[faceRectangleDataGridViewTextBoxColumn.Index, e.RowIndex].Value.ToString();
                        var imageData = dgvImagesInDb[imageBytesDataGridViewImageColumn.Index, e.RowIndex].Value;
                        if (imageData is byte[] imageArray)
                        {
                            string FaceListID = string.Empty;
                            using (var db = new LiveEduFaceModel())
                            {
                                Microsoft.ProjectOxford.Face.Contract.Face[] FaceDetect = null;
                                FaceDetect = Task.Run(async () => await Facial_Recognition_Library.API.ProjectOxfordAPI.DetectFace(new MemoryStream(imageArray))).Result;
                                if (FaceDetect.Length > 1)
                                {
                                    //Output the image to a temporary storage and show it to the end user WITH the Rectangles on it, this way the user can SEE the faces detected.
                                    throw new Facial_Recognition_Library.Controls.DataGridViewsFaceDetectException($@"More than one face found in this image. Please review image in temp folder {Facial_Recognition_Library.IO.FileSystemManager.TempImageLocationForErrors} ");
                                }

                                var FaceToUpdate = db.MyFaces.Where((f) => f.ID == faceSystemId);
                                foreach (var face in FaceToUpdate)
                                {
                                    face.FaceID = FaceDetect[0].FaceId;
                                    face.DateLastDetected = DateTime.Now;
                                }

                                db.SaveChanges();

                                methodResult.Success = true;
                                methodResult.ShouldRefreshDatabaseDataGrids = true;
                                return methodResult;
                            }
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine($"Image Array was empty. You must ensure that there is an image with which to send. (cannot send 0 bytes)");
                            methodResult.Success = false;
                        }

                        return methodResult;
                    }
                    //NAME: Add Face to FaceList By FaceListID
                    else if (e.ColumnIndex == dgvImagesInDb.Columns[Column.Name]?.Index)
                    {
                        System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex}");

                        Guid FaceSystemID = new Guid(dgvImagesInDb[Column.Index, e.RowIndex].Value.ToString());
                        string Rectangle = dgvImagesInDb[Column.Index, e.RowIndex].Value.ToString();
                        var ImageData = dgvImagesInDb[Column.Index, e.RowIndex].Value;
                        if (ImageData is byte[] imageArray) //if ImageData is not Null.
                        {
                            string FaceListID = string.Empty;

                            using (var db = new LiveEduFaceModel())
                            {
                                FaceListID = db.MyFaceLists.First().FaceListId;
                                Microsoft.ProjectOxford.Face.Contract.FaceRectangle faceRectangle = Newtonsoft.Json.JsonConvert.DeserializeObject<Microsoft.ProjectOxford.Face.Contract.FaceRectangle>(Rectangle);
                                var FaceListFacePersistantID = Facial_Recognition_Library.API.ProjectOxfordAPI.AddFaceToFaceListByFaceListID(FaceListID, new MemoryStream(imageArray), null, faceRectangle).Result;
                                var FaceToUpdate = db.MyFaces.Where((f) => f.ID == FaceSystemID);
                                foreach (var face in FaceToUpdate)
                                {
                                    face.FaceListPersistantID = FaceListFacePersistantID;
                                    face.DateLastDetected = DateTime.Now;
                                }

                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine($"Image Array was empty. You must ensure that there is an image with which to send. (cannot send 0 bytes)");
                            methodResult.Success = false;
                        }
                        return methodResult;
                    }
                }
                else
                {
                    return methodResult;
                }
            }

            return null;
        }


        /// <summary>
        /// Event handlers for the Data Grid View "Person Groups"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="dgvc"></param>
        /// <returns></returns>
        public static DataGridViewsProcessResult DgvPersonGroups(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn dgvc)
        {
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();

            return methodResult;
        }

        /// <summary>
        /// Event handlers for the Data Grid View "Face Lists In DB"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static DataGridViewsProcessResult DgvFaceListDb(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn column)
        {
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();
            if (sender is DataGridView dgvFaceListInDB)
            {
                if (e.RowIndex < 0) return null;
                //NAME: Delete Face List
                if (e.ColumnIndex == dgvFaceListInDB.Columns[column.Name]?.Index)
                {
                    //NAME: DELETE FACE LIST
                    //TODO: The Cell Reference needs to be exact so that users can move the Columns.
                    Guid faceListDbid = (Guid)dgvFaceListInDB[0, e.RowIndex].Value;
                    var concent = MessageBox.Show($@"Are you sure you want to delete {faceListDbid.ToString()} from the DB and API?", $@"Remove Face List", MessageBoxButtons.OKCancel);
                    if (concent == DialogResult.OK)
                    {
                        string faceListId = "";
                        using (var db = new LiveEduFaceModel())
                        {
                            var myFaceList = db.MyFaceLists.Single(x => x.ID == faceListDbid);
                            faceListId = myFaceList.FaceListId;
                            db.MyFaceLists.Remove(myFaceList);
                            db.SaveChanges();
                        }
                        bool Success = ProjectOxfordAPI.DeleteFaceListByFaceListID(faceListId).Result;
                        if (Success)
                        {
                            MessageBox.Show($@"Item Removed: Refreshing Data");
                            //LoadAPIFaceList();
                        }
                    }
                    else
                    {

                    }
                }
                else if (e.ColumnIndex == dgvFaceListInDB.Columns[column.Name]?.Index)
                {
                    //SHOW FACE LIST DETAILS

                }
                else
                {

                }
            }

            return methodResult;
        }

        public static DataGridViewsProcessResult DgvPersonDb(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn column)
        {
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();
            return methodResult;
        }

        public static DataGridViewsProcessResult DgvPersonApi(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn column)
        {
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();
            return methodResult;
        }

        #endregion

        #region Async Equals > These items are not final or tested. Please review before use. 
        /// <summary>
        /// Event handlers for the Data Grid View "Images In DB"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="Column"></param>
        /// <param name="DataGridViewColumns"></param>
        /// <exception cref="Facial_Recognition_Library.Controls.DataGridViewsFaceDetectException">This is thrown with an image contains more than one face. We cannot register a face when more than one is within the image.</exception>
        /// <returns></returns>
        public static DataGridViewsProcessResult DgvImagesInDbAsync(ref object sender, DataGridViewCellEventArgs e, DataGridViewColumn Column, params DataGridViewColumn[] DataGridViewColumns)
        {
            throw new NotImplementedException("The ASYNC methods have not been compeleted. Please review and remove this exception before use.");
            DataGridViewsProcessResult methodResult = new DataGridViewsProcessResult();
            DataGridView dgvImagesInDb = (DataGridView)sender;

            if (Column != null)
            {
                DataGridViewColumn ResendToDetect = Column;
                DataGridViewColumn dgvBtnAddToCurrentFaceList = Column;

                DataGridViewColumn SystemIDdgvtxtColumn = null;
                DataGridViewColumn faceRectangleDataGridViewTextBoxColumn = null;
                DataGridViewColumn imageBytesDataGridViewImageColumn = null;

                bool GridViewColumnsInitialized = false;
                if (DataGridViewColumns?.Length > 0)
                {
                    try
                    {
                        SystemIDdgvtxtColumn = DataGridViewColumns.First(dgvc => dgvc.Name == "SystemIDdgvtxtColumn");
                        faceRectangleDataGridViewTextBoxColumn = DataGridViewColumns.First(dgvc => dgvc.Name == "faceRectangleDataGridViewTextBoxColumn");
                        imageBytesDataGridViewImageColumn = DataGridViewColumns.First(dgvc => dgvc.Name == "imageBytesDataGridViewImageColumn");
                        GridViewColumnsInitialized = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex);
                        System.Diagnostics.Debug.WriteLine($"Failed to retrieve the columns for data retrieval.");
                        methodResult.Success = false;
                    }
                }
                else
                {
                    SystemIDdgvtxtColumn = dgvImagesInDb.Columns.OfType<DataGridViewColumn>().First(dgvc => dgvc.Name == "SystemIdDataGridViewTextBoxColumn");
                    faceRectangleDataGridViewTextBoxColumn = dgvImagesInDb.Columns.OfType<DataGridViewColumn>().First(dgvc => dgvc.Name == "rectangleDataGridViewTextBoxColumn");
                    imageBytesDataGridViewImageColumn = dgvImagesInDb.Columns.OfType<DataGridViewColumn>().First(dgvc => dgvc.Name == "dataGridViewImageColumn2");
                }

                //Providing this style of Index lookup allows the Columns to be moved around. so the function stays the same
                if (e.ColumnIndex == dgvImagesInDb.Columns[ResendToDetect.Name].Index)
                {
                    System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex}");
                    Guid FaceSystemID = new Guid(dgvImagesInDb[SystemIDdgvtxtColumn.Index, e.RowIndex].Value.ToString());
                    string Rectangle = dgvImagesInDb[faceRectangleDataGridViewTextBoxColumn.Index, e.RowIndex].Value.ToString();
                    var ImageData = dgvImagesInDb[imageBytesDataGridViewImageColumn.Index, e.RowIndex].Value;
                    if (ImageData is byte[] ImageArray)//if ImageData is not Null.
                    {
                        string FaceListID = string.Empty;
                        Task.Run(async () =>
                        {
                            using (var db = new LiveEduFaceModel())
                            {
                                Microsoft.ProjectOxford.Face.Contract.Face[] FaceDetect = null;
                                FaceDetect = await Facial_Recognition_Library.API.ProjectOxfordAPI.DetectFace(new MemoryStream(ImageArray));
                                if (FaceDetect.Length > 1)
                                {
                                    //Output the image to a temporary storage and show it to the end user WITH the Rectangles on it, this way the user can SEE the faces detected.
                                    throw new Facial_Recognition_Library.Controls.DataGridViewsFaceDetectException($@"More than one face found in this image. Please review image in temp folder {Facial_Recognition_Library.IO.FileSystemManager.TempImageLocationForErrors} ");
                                }
                                var FaceToUpdate = db.MyFaces.Where((f) => f.ID == FaceSystemID);
                                foreach (var face in FaceToUpdate)
                                {
                                    face.FaceID = FaceDetect[0].FaceId;
                                    face.DateLastDetected = DateTime.Now;
                                }
                                db.SaveChanges();
                                methodResult.Success = true;
                                methodResult.ShouldRefreshDatabaseDataGrids = true;
                                return methodResult;
                            }
                        });
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Image Array was empty. You must ensure that there is an image with which to send. (cannot send 0 bytes)");
                        methodResult.Success = false;
                    }

                    return methodResult;
                }
                else if (e.ColumnIndex == dgvImagesInDb.Columns[dgvBtnAddToCurrentFaceList.Name].Index)
                {
                    System.Diagnostics.Debug.WriteLine($"Row index is {e.RowIndex}");
                    if (GridViewColumnsInitialized)
                    {
                        //TODO: Move this to the libary : dgvImagesInDb_CellClick : dgvImagesInDb.Columns[dgvBtnAddToCurrentFaceList.Name].Index
                        Guid FaceSystemID = new Guid(dgvImagesInDb[SystemIDdgvtxtColumn.Index, e.RowIndex].Value.ToString());
                        string Rectangle = dgvImagesInDb[faceRectangleDataGridViewTextBoxColumn.Index, e.RowIndex].Value.ToString();
                        var ImageData = dgvImagesInDb[imageBytesDataGridViewImageColumn.Index, e.RowIndex].Value;
                        byte[] ImageArray = ImageData as byte[];
                        if (ImageArray != null)
                        {
                            string FaceListID = string.Empty;

                            using (var db = new LiveEduFaceModel())
                            {
                                FaceListID = db.MyFaceLists.First().FaceListId;

                                Microsoft.ProjectOxford.Face.Contract.FaceRectangle faceRectangle = Newtonsoft.Json.JsonConvert.DeserializeObject<Microsoft.ProjectOxford.Face.Contract.FaceRectangle>(Rectangle);

                                var FaceListFacePersistantID = Facial_Recognition_Library.API.ProjectOxfordAPI.AddFaceToFaceListByFaceListID(FaceListID, new MemoryStream(ImageArray), null, faceRectangle).Result;

                                var FaceToUpdate = db.MyFaces.Where((f) => f.ID == FaceSystemID);

                                foreach (var face in FaceToUpdate)
                                {
                                    face.FaceListPersistantID = FaceListFacePersistantID;
                                    face.DateLastDetected = DateTime.Now;
                                }
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine($"Image Array was empty. You must ensure that there is an image with which to send. (cannot send 0 bytes)");
                            methodResult.Success = false;
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Columns needed for lookup failed to retrieve, check the execptions list.");
                    }
                    return methodResult;
                }
            }
            else
            {
                return methodResult;
            }

            return null;
        }
        #endregion

    }
}
