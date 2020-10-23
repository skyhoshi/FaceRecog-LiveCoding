namespace Face_Recognition_Debug_Application
{
    partial class frmFaceDBData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaceDBData));
            this.dgvImagesInDb = new System.Windows.Forms.DataGridView();
            this.ResendToDetect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnAddToCurrentFaceList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SystemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaceListPersistantIDtxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLastDetected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceLandmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectangleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceListPersistantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facePersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLastDetectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedToFaceListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedToPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedToPersonGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DatabaseFaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsFaceAttributes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reviewAllAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlDataSections = new System.Windows.Forms.TabControl();
            this.tpDatabaseSection = new System.Windows.Forms.TabPage();
            this.tabControlDatabase = new System.Windows.Forms.TabControl();
            this.tpImageInDB = new System.Windows.Forms.TabPage();
            this.tpFaceLInDB = new System.Windows.Forms.TabPage();
            this.dgvFaceListInDB = new System.Windows.Forms.DataGridView();
            this.dgvbtnDeleteRowAndFaceList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SystemIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addeDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabaseFaceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpPersonGroups = new System.Windows.Forms.TabPage();
            this.dgvDatabasePersonGroups = new System.Windows.Forms.DataGridView();
            this.PersonGroupNameDGVtxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabasePersonGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpPerson = new System.Windows.Forms.TabPage();
            this.dgvDatabasePersons = new System.Windows.Forms.DataGridView();
            this.systemPersonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabasePersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpAPIDataSection = new System.Windows.Forms.TabPage();
            this.tabControlAPIData = new System.Windows.Forms.TabControl();
            this.tpFaceLInAPI = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvFaceAPIFaceLists = new System.Windows.Forms.DataGridView();
            this.dgvbtnShowFaceListDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnRemoveFaceList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APIFaceListMetadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetrieveFaceListFromAPI = new System.Windows.Forms.Button();
            this.tpPersonGLInAPI = new System.Windows.Forms.TabPage();
            this.dgvPersonGroups = new System.Windows.Forms.DataGridView();
            this.dgvbtnDeletePersonGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvbtnViewPersonGroupDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.personGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APIPersonGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpPersonInAPI = new System.Windows.Forms.TabPage();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.dgvbtnDeletePerson = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvbtnViewPersonDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APIPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolstripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personGroupToolstripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshFaceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFaceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFaceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPersonGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPersonGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPersonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllDataItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceFindValidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findSimilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupFacesFromListofFacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personFindValidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyFaceBelongsToAPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifyFaceAmongAPersonGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unusedMenuItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshApiListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsAPIPersonFunctions = new System.Windows.Forms.ToolStrip();
            this.tsbtnPersonRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPersonDelete = new System.Windows.Forms.ToolStripButton();
            this.faceListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personGroupsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.persistedFaceIdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterFaceIntoDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagesInDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFaceBindingSource)).BeginInit();
            this.cmsFaceAttributes.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlDataSections.SuspendLayout();
            this.tpDatabaseSection.SuspendLayout();
            this.tabControlDatabase.SuspendLayout();
            this.tpImageInDB.SuspendLayout();
            this.tpFaceLInDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaceListInDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFaceListBindingSource)).BeginInit();
            this.tpPersonGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabasePersonGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePersonGroupBindingSource)).BeginInit();
            this.tpPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabasePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePersonBindingSource)).BeginInit();
            this.tpAPIDataSection.SuspendLayout();
            this.tabControlAPIData.SuspendLayout();
            this.tpFaceLInAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaceAPIFaceLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIFaceListMetadataBindingSource)).BeginInit();
            this.tpPersonGLInAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIPersonGroupBindingSource)).BeginInit();
            this.tpPersonInAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIPersonBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tsAPIPersonFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persistedFaceIdsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImagesInDb
            // 
            this.dgvImagesInDb.AllowUserToAddRows = false;
            this.dgvImagesInDb.AllowUserToDeleteRows = false;
            this.dgvImagesInDb.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImagesInDb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImagesInDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagesInDb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResendToDetect,
            this.dgvBtnAddToCurrentFaceList,
            this.dataGridViewImageColumn1,
            this.SystemIdDataGridViewTextBoxColumn,
            this.FaceListPersistantIDtxtColumn,
            this.faceIDDataGridViewTextBoxColumn,
            this.DateLastDetected,
            this.dataGridViewTextBoxColumn1,
            this.attributesDataGridViewTextBoxColumn,
            this.faceLandmarksDataGridViewTextBoxColumn,
            this.landmarksDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.rectangleDataGridViewTextBoxColumn,
            this.faceListPersistantIDDataGridViewTextBoxColumn,
            this.facePersonIDDataGridViewTextBoxColumn,
            this.dateLastDetectedDataGridViewTextBoxColumn,
            this.dateAddedToFaceListDataGridViewTextBoxColumn,
            this.dateAddedToPersonDataGridViewTextBoxColumn,
            this.dateAddedToPersonGroupDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn2});
            this.dgvImagesInDb.DataSource = this.DatabaseFaceBindingSource;
            this.dgvImagesInDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImagesInDb.Location = new System.Drawing.Point(3, 3);
            this.dgvImagesInDb.MultiSelect = false;
            this.dgvImagesInDb.Name = "dgvImagesInDb";
            this.dgvImagesInDb.ReadOnly = true;
            this.dgvImagesInDb.Size = new System.Drawing.Size(776, 301);
            this.dgvImagesInDb.TabIndex = 0;
            this.dgvImagesInDb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImagesInDb_CellClick);
            // 
            // ResendToDetect
            // 
            this.ResendToDetect.HeaderText = "Resend To API";
            this.ResendToDetect.Name = "ResendToDetect";
            this.ResendToDetect.ReadOnly = true;
            // 
            // dgvBtnAddToCurrentFaceList
            // 
            this.dgvBtnAddToCurrentFaceList.HeaderText = "Add To Current Face List";
            this.dgvBtnAddToCurrentFaceList.Name = "dgvBtnAddToCurrentFaceList";
            this.dgvBtnAddToCurrentFaceList.ReadOnly = true;
            this.dgvBtnAddToCurrentFaceList.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "BitmapImage";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // SystemIdDataGridViewTextBoxColumn
            // 
            this.SystemIdDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.SystemIdDataGridViewTextBoxColumn.HeaderText = "System ID";
            this.SystemIdDataGridViewTextBoxColumn.Name = "SystemIdDataGridViewTextBoxColumn";
            this.SystemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FaceListPersistantIDtxtColumn
            // 
            this.FaceListPersistantIDtxtColumn.DataPropertyName = "FaceListPersistantID";
            this.FaceListPersistantIDtxtColumn.HeaderText = "Face List Persistant ID";
            this.FaceListPersistantIDtxtColumn.Name = "FaceListPersistantIDtxtColumn";
            this.FaceListPersistantIDtxtColumn.ReadOnly = true;
            // 
            // faceIDDataGridViewTextBoxColumn
            // 
            this.faceIDDataGridViewTextBoxColumn.DataPropertyName = "FaceID";
            this.faceIDDataGridViewTextBoxColumn.HeaderText = "Face ID[api]";
            this.faceIDDataGridViewTextBoxColumn.Name = "faceIDDataGridViewTextBoxColumn";
            this.faceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DateLastDetected
            // 
            this.DateLastDetected.DataPropertyName = "DateLastDetected";
            this.DateLastDetected.HeaderText = "Last Sent to API";
            this.DateLastDetected.Name = "DateLastDetected";
            this.DateLastDetected.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FaceAttributes";
            this.dataGridViewTextBoxColumn1.HeaderText = "FaceAttributes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // attributesDataGridViewTextBoxColumn
            // 
            this.attributesDataGridViewTextBoxColumn.DataPropertyName = "Attributes";
            this.attributesDataGridViewTextBoxColumn.HeaderText = "Attributes";
            this.attributesDataGridViewTextBoxColumn.Name = "attributesDataGridViewTextBoxColumn";
            this.attributesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faceLandmarksDataGridViewTextBoxColumn
            // 
            this.faceLandmarksDataGridViewTextBoxColumn.DataPropertyName = "FaceLandmarks";
            this.faceLandmarksDataGridViewTextBoxColumn.HeaderText = "FaceLandmarks";
            this.faceLandmarksDataGridViewTextBoxColumn.Name = "faceLandmarksDataGridViewTextBoxColumn";
            this.faceLandmarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // landmarksDataGridViewTextBoxColumn
            // 
            this.landmarksDataGridViewTextBoxColumn.DataPropertyName = "Landmarks";
            this.landmarksDataGridViewTextBoxColumn.HeaderText = "Landmarks";
            this.landmarksDataGridViewTextBoxColumn.Name = "landmarksDataGridViewTextBoxColumn";
            this.landmarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FaceRectangle";
            this.dataGridViewTextBoxColumn2.HeaderText = "FaceRectangle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rectangleDataGridViewTextBoxColumn
            // 
            this.rectangleDataGridViewTextBoxColumn.DataPropertyName = "Rectangle";
            this.rectangleDataGridViewTextBoxColumn.HeaderText = "Rectangle";
            this.rectangleDataGridViewTextBoxColumn.Name = "rectangleDataGridViewTextBoxColumn";
            this.rectangleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faceListPersistantIDDataGridViewTextBoxColumn
            // 
            this.faceListPersistantIDDataGridViewTextBoxColumn.DataPropertyName = "FaceListPersistantID";
            this.faceListPersistantIDDataGridViewTextBoxColumn.HeaderText = "FaceListPersistantID";
            this.faceListPersistantIDDataGridViewTextBoxColumn.Name = "faceListPersistantIDDataGridViewTextBoxColumn";
            this.faceListPersistantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facePersonIDDataGridViewTextBoxColumn
            // 
            this.facePersonIDDataGridViewTextBoxColumn.DataPropertyName = "FacePersonID";
            this.facePersonIDDataGridViewTextBoxColumn.HeaderText = "FacePersonID";
            this.facePersonIDDataGridViewTextBoxColumn.Name = "facePersonIDDataGridViewTextBoxColumn";
            this.facePersonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateLastDetectedDataGridViewTextBoxColumn
            // 
            this.dateLastDetectedDataGridViewTextBoxColumn.DataPropertyName = "DateLastDetected";
            this.dateLastDetectedDataGridViewTextBoxColumn.HeaderText = "DateLastDetected";
            this.dateLastDetectedDataGridViewTextBoxColumn.Name = "dateLastDetectedDataGridViewTextBoxColumn";
            this.dateLastDetectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedToFaceListDataGridViewTextBoxColumn
            // 
            this.dateAddedToFaceListDataGridViewTextBoxColumn.DataPropertyName = "DateAddedToFaceList";
            this.dateAddedToFaceListDataGridViewTextBoxColumn.HeaderText = "DateAddedToFaceList";
            this.dateAddedToFaceListDataGridViewTextBoxColumn.Name = "dateAddedToFaceListDataGridViewTextBoxColumn";
            this.dateAddedToFaceListDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedToPersonDataGridViewTextBoxColumn
            // 
            this.dateAddedToPersonDataGridViewTextBoxColumn.DataPropertyName = "DateAddedToPerson";
            this.dateAddedToPersonDataGridViewTextBoxColumn.HeaderText = "DateAddedToPerson";
            this.dateAddedToPersonDataGridViewTextBoxColumn.Name = "dateAddedToPersonDataGridViewTextBoxColumn";
            this.dateAddedToPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedToPersonGroupDataGridViewTextBoxColumn
            // 
            this.dateAddedToPersonGroupDataGridViewTextBoxColumn.DataPropertyName = "DateAddedToPersonGroup";
            this.dateAddedToPersonGroupDataGridViewTextBoxColumn.HeaderText = "DateAddedToPersonGroup";
            this.dateAddedToPersonGroupDataGridViewTextBoxColumn.Name = "dateAddedToPersonGroupDataGridViewTextBoxColumn";
            this.dateAddedToPersonGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "ImageBytes";
            this.dataGridViewImageColumn2.HeaderText = "Raw Image";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // DatabaseFaceBindingSource
            // 
            this.DatabaseFaceBindingSource.DataSource = typeof(Facial_Recognition_Library.Data.tbls.MyFace);
            // 
            // cmsFaceAttributes
            // 
            this.cmsFaceAttributes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewAllAttributesToolStripMenuItem});
            this.cmsFaceAttributes.Name = "cmsFaceAttributes";
            this.cmsFaceAttributes.Size = new System.Drawing.Size(184, 26);
            this.cmsFaceAttributes.Text = "Face Attributes";
            // 
            // reviewAllAttributesToolStripMenuItem
            // 
            this.reviewAllAttributesToolStripMenuItem.Name = "reviewAllAttributesToolStripMenuItem";
            this.reviewAllAttributesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.reviewAllAttributesToolStripMenuItem.Text = "Review All Attributes";
            this.reviewAllAttributesToolStripMenuItem.Click += new System.EventHandler(this.reviewAllAttributesToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlDataSections);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(804, 365);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(804, 461);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsAPIPersonFunctions);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "Current Status : Ready";
            // 
            // tabControlDataSections
            // 
            this.tabControlDataSections.Controls.Add(this.tpDatabaseSection);
            this.tabControlDataSections.Controls.Add(this.tpAPIDataSection);
            this.tabControlDataSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDataSections.Location = new System.Drawing.Point(0, 0);
            this.tabControlDataSections.Name = "tabControlDataSections";
            this.tabControlDataSections.SelectedIndex = 0;
            this.tabControlDataSections.Size = new System.Drawing.Size(804, 365);
            this.tabControlDataSections.TabIndex = 2;
            // 
            // tpDatabaseSection
            // 
            this.tpDatabaseSection.Controls.Add(this.tabControlDatabase);
            this.tpDatabaseSection.Location = new System.Drawing.Point(4, 22);
            this.tpDatabaseSection.Name = "tpDatabaseSection";
            this.tpDatabaseSection.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatabaseSection.Size = new System.Drawing.Size(796, 339);
            this.tpDatabaseSection.TabIndex = 0;
            this.tpDatabaseSection.Text = "Database Section";
            this.tpDatabaseSection.UseVisualStyleBackColor = true;
            // 
            // tabControlDatabase
            // 
            this.tabControlDatabase.Controls.Add(this.tpImageInDB);
            this.tabControlDatabase.Controls.Add(this.tpFaceLInDB);
            this.tabControlDatabase.Controls.Add(this.tpPersonGroups);
            this.tabControlDatabase.Controls.Add(this.tpPerson);
            this.tabControlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDatabase.Location = new System.Drawing.Point(3, 3);
            this.tabControlDatabase.Name = "tabControlDatabase";
            this.tabControlDatabase.SelectedIndex = 0;
            this.tabControlDatabase.Size = new System.Drawing.Size(790, 333);
            this.tabControlDatabase.TabIndex = 1;
            this.tabControlDatabase.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpImageInDB
            // 
            this.tpImageInDB.Controls.Add(this.dgvImagesInDb);
            this.tpImageInDB.Location = new System.Drawing.Point(4, 22);
            this.tpImageInDB.Name = "tpImageInDB";
            this.tpImageInDB.Padding = new System.Windows.Forms.Padding(3);
            this.tpImageInDB.Size = new System.Drawing.Size(782, 307);
            this.tpImageInDB.TabIndex = 0;
            this.tpImageInDB.Text = "Images of Faces";
            this.tpImageInDB.UseVisualStyleBackColor = true;
            // 
            // tpFaceLInDB
            // 
            this.tpFaceLInDB.Controls.Add(this.dgvFaceListInDB);
            this.tpFaceLInDB.Location = new System.Drawing.Point(4, 22);
            this.tpFaceLInDB.Name = "tpFaceLInDB";
            this.tpFaceLInDB.Padding = new System.Windows.Forms.Padding(3);
            this.tpFaceLInDB.Size = new System.Drawing.Size(782, 307);
            this.tpFaceLInDB.TabIndex = 1;
            this.tpFaceLInDB.Text = "Face Lists";
            this.tpFaceLInDB.UseVisualStyleBackColor = true;
            // 
            // dgvFaceListInDB
            // 
            this.dgvFaceListInDB.AllowUserToAddRows = false;
            this.dgvFaceListInDB.AllowUserToDeleteRows = false;
            this.dgvFaceListInDB.AutoGenerateColumns = false;
            this.dgvFaceListInDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaceListInDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnDeleteRowAndFaceList,
            this.SystemIdDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.addeDateTimeDataGridViewTextBoxColumn,
            this.modifiedDateTimeDataGridViewTextBoxColumn});
            this.dgvFaceListInDB.DataSource = this.DatabaseFaceListBindingSource;
            this.dgvFaceListInDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaceListInDB.Location = new System.Drawing.Point(3, 3);
            this.dgvFaceListInDB.Name = "dgvFaceListInDB";
            this.dgvFaceListInDB.ReadOnly = true;
            this.dgvFaceListInDB.Size = new System.Drawing.Size(776, 301);
            this.dgvFaceListInDB.TabIndex = 0;
            this.dgvFaceListInDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaceListInDB_CellClick);
            // 
            // dgvbtnDeleteRowAndFaceList
            // 
            this.dgvbtnDeleteRowAndFaceList.HeaderText = "Delete Row and Face List";
            this.dgvbtnDeleteRowAndFaceList.Name = "dgvbtnDeleteRowAndFaceList";
            this.dgvbtnDeleteRowAndFaceList.ReadOnly = true;
            this.dgvbtnDeleteRowAndFaceList.Text = "Delete and Remove";
            this.dgvbtnDeleteRowAndFaceList.Width = 150;
            // 
            // SystemIdDataGridViewTextBoxColumn2
            // 
            this.SystemIdDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.SystemIdDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.SystemIdDataGridViewTextBoxColumn2.Name = "SystemIdDataGridViewTextBoxColumn2";
            this.SystemIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FaceListId";
            this.dataGridViewTextBoxColumn3.HeaderText = "FaceListId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserData";
            this.dataGridViewTextBoxColumn5.HeaderText = "UserData";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // addeDateTimeDataGridViewTextBoxColumn
            // 
            this.addeDateTimeDataGridViewTextBoxColumn.DataPropertyName = "AddeDateTime";
            this.addeDateTimeDataGridViewTextBoxColumn.HeaderText = "AddeDateTime";
            this.addeDateTimeDataGridViewTextBoxColumn.Name = "addeDateTimeDataGridViewTextBoxColumn";
            this.addeDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedDateTimeDataGridViewTextBoxColumn
            // 
            this.modifiedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDateTime";
            this.modifiedDateTimeDataGridViewTextBoxColumn.HeaderText = "ModifiedDateTime";
            this.modifiedDateTimeDataGridViewTextBoxColumn.Name = "modifiedDateTimeDataGridViewTextBoxColumn";
            this.modifiedDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DatabaseFaceListBindingSource
            // 
            this.DatabaseFaceListBindingSource.DataSource = typeof(Facial_Recognition_Library.Data.tbls.MyFaceList);
            // 
            // tpPersonGroups
            // 
            this.tpPersonGroups.Controls.Add(this.dgvDatabasePersonGroups);
            this.tpPersonGroups.Location = new System.Drawing.Point(4, 22);
            this.tpPersonGroups.Name = "tpPersonGroups";
            this.tpPersonGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonGroups.Size = new System.Drawing.Size(782, 307);
            this.tpPersonGroups.TabIndex = 2;
            this.tpPersonGroups.Text = "Person Groups";
            this.tpPersonGroups.UseVisualStyleBackColor = true;
            // 
            // dgvDatabasePersonGroups
            // 
            this.dgvDatabasePersonGroups.AllowUserToAddRows = false;
            this.dgvDatabasePersonGroups.AllowUserToDeleteRows = false;
            this.dgvDatabasePersonGroups.AutoGenerateColumns = false;
            this.dgvDatabasePersonGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabasePersonGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonGroupNameDGVtxtColumn,
            this.dataGridViewTextBoxColumn14});
            this.dgvDatabasePersonGroups.DataSource = this.DatabasePersonGroupBindingSource;
            this.dgvDatabasePersonGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabasePersonGroups.Location = new System.Drawing.Point(3, 3);
            this.dgvDatabasePersonGroups.Name = "dgvDatabasePersonGroups";
            this.dgvDatabasePersonGroups.ReadOnly = true;
            this.dgvDatabasePersonGroups.Size = new System.Drawing.Size(776, 301);
            this.dgvDatabasePersonGroups.TabIndex = 0;
            // 
            // PersonGroupNameDGVtxtColumn
            // 
            this.PersonGroupNameDGVtxtColumn.DataPropertyName = "Name";
            this.PersonGroupNameDGVtxtColumn.HeaderText = "Name";
            this.PersonGroupNameDGVtxtColumn.Name = "PersonGroupNameDGVtxtColumn";
            this.PersonGroupNameDGVtxtColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UserData";
            this.dataGridViewTextBoxColumn14.HeaderText = "UserData";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // DatabasePersonGroupBindingSource
            // 
            this.DatabasePersonGroupBindingSource.AllowNew = false;
            this.DatabasePersonGroupBindingSource.DataSource = typeof(Facial_Recognition_Library.Data.tbls.MyPersonGroup);
            // 
            // tpPerson
            // 
            this.tpPerson.Controls.Add(this.dgvDatabasePersons);
            this.tpPerson.Location = new System.Drawing.Point(4, 22);
            this.tpPerson.Name = "tpPerson";
            this.tpPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerson.Size = new System.Drawing.Size(782, 307);
            this.tpPerson.TabIndex = 3;
            this.tpPerson.Text = "Person";
            this.tpPerson.UseVisualStyleBackColor = true;
            // 
            // dgvDatabasePersons
            // 
            this.dgvDatabasePersons.AllowUserToAddRows = false;
            this.dgvDatabasePersons.AllowUserToDeleteRows = false;
            this.dgvDatabasePersons.AutoGenerateColumns = false;
            this.dgvDatabasePersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabasePersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemPersonIdDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgvDatabasePersons.DataSource = this.DatabasePersonBindingSource;
            this.dgvDatabasePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabasePersons.Location = new System.Drawing.Point(3, 3);
            this.dgvDatabasePersons.Name = "dgvDatabasePersons";
            this.dgvDatabasePersons.ReadOnly = true;
            this.dgvDatabasePersons.Size = new System.Drawing.Size(776, 301);
            this.dgvDatabasePersons.TabIndex = 0;
            // 
            // systemPersonIdDataGridViewTextBoxColumn
            // 
            this.systemPersonIdDataGridViewTextBoxColumn.DataPropertyName = "SystemPersonId";
            this.systemPersonIdDataGridViewTextBoxColumn.HeaderText = "SystemPersonId";
            this.systemPersonIdDataGridViewTextBoxColumn.Name = "systemPersonIdDataGridViewTextBoxColumn";
            this.systemPersonIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIdDataGridViewTextBoxColumn1
            // 
            this.personIdDataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn1.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn1.Name = "personIdDataGridViewTextBoxColumn1";
            this.personIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn15.HeaderText = "Name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UserData";
            this.dataGridViewTextBoxColumn16.HeaderText = "UserData";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // DatabasePersonBindingSource
            // 
            this.DatabasePersonBindingSource.DataSource = typeof(Facial_Recognition_Library.Data.tbls.MyPerson);
            // 
            // tpAPIDataSection
            // 
            this.tpAPIDataSection.Controls.Add(this.tabControlAPIData);
            this.tpAPIDataSection.Location = new System.Drawing.Point(4, 22);
            this.tpAPIDataSection.Name = "tpAPIDataSection";
            this.tpAPIDataSection.Padding = new System.Windows.Forms.Padding(3);
            this.tpAPIDataSection.Size = new System.Drawing.Size(796, 339);
            this.tpAPIDataSection.TabIndex = 1;
            this.tpAPIDataSection.Text = "API Section";
            this.tpAPIDataSection.UseVisualStyleBackColor = true;
            // 
            // tabControlAPIData
            // 
            this.tabControlAPIData.Controls.Add(this.tpFaceLInAPI);
            this.tabControlAPIData.Controls.Add(this.tpPersonGLInAPI);
            this.tabControlAPIData.Controls.Add(this.tpPersonInAPI);
            this.tabControlAPIData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAPIData.Location = new System.Drawing.Point(3, 3);
            this.tabControlAPIData.Name = "tabControlAPIData";
            this.tabControlAPIData.SelectedIndex = 0;
            this.tabControlAPIData.Size = new System.Drawing.Size(790, 333);
            this.tabControlAPIData.TabIndex = 0;
            // 
            // tpFaceLInAPI
            // 
            this.tpFaceLInAPI.Controls.Add(this.splitContainer1);
            this.tpFaceLInAPI.Location = new System.Drawing.Point(4, 22);
            this.tpFaceLInAPI.Name = "tpFaceLInAPI";
            this.tpFaceLInAPI.Size = new System.Drawing.Size(782, 307);
            this.tpFaceLInAPI.TabIndex = 2;
            this.tpFaceLInAPI.Text = "Face Lists";
            this.tpFaceLInAPI.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFaceAPIFaceLists);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRetrieveFaceListFromAPI);
            this.splitContainer1.Size = new System.Drawing.Size(782, 307);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvFaceAPIFaceLists
            // 
            this.dgvFaceAPIFaceLists.AllowUserToAddRows = false;
            this.dgvFaceAPIFaceLists.AllowUserToDeleteRows = false;
            this.dgvFaceAPIFaceLists.AutoGenerateColumns = false;
            this.dgvFaceAPIFaceLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaceAPIFaceLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnShowFaceListDetails,
            this.dgvBtnRemoveFaceList,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvFaceAPIFaceLists.DataSource = this.APIFaceListMetadataBindingSource;
            this.dgvFaceAPIFaceLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaceAPIFaceLists.Location = new System.Drawing.Point(0, 0);
            this.dgvFaceAPIFaceLists.Name = "dgvFaceAPIFaceLists";
            this.dgvFaceAPIFaceLists.ReadOnly = true;
            this.dgvFaceAPIFaceLists.Size = new System.Drawing.Size(782, 278);
            this.dgvFaceAPIFaceLists.TabIndex = 0;
            this.dgvFaceAPIFaceLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaceAPIFaceLists_CellClick);
            // 
            // dgvbtnShowFaceListDetails
            // 
            this.dgvbtnShowFaceListDetails.HeaderText = "Show Face List Details";
            this.dgvbtnShowFaceListDetails.Name = "dgvbtnShowFaceListDetails";
            this.dgvbtnShowFaceListDetails.ReadOnly = true;
            // 
            // dgvBtnRemoveFaceList
            // 
            this.dgvBtnRemoveFaceList.HeaderText = "Remove Face List From API";
            this.dgvBtnRemoveFaceList.Name = "dgvBtnRemoveFaceList";
            this.dgvBtnRemoveFaceList.ReadOnly = true;
            this.dgvBtnRemoveFaceList.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FaceListId";
            this.dataGridViewTextBoxColumn6.HeaderText = "FaceListId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserData";
            this.dataGridViewTextBoxColumn8.HeaderText = "UserData";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // APIFaceListMetadataBindingSource
            // 
            this.APIFaceListMetadataBindingSource.DataSource = typeof(Microsoft.ProjectOxford.Face.Contract.FaceListMetadata);
            // 
            // btnRetrieveFaceListFromAPI
            // 
            this.btnRetrieveFaceListFromAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrieveFaceListFromAPI.Location = new System.Drawing.Point(704, -1);
            this.btnRetrieveFaceListFromAPI.Name = "btnRetrieveFaceListFromAPI";
            this.btnRetrieveFaceListFromAPI.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieveFaceListFromAPI.TabIndex = 1;
            this.btnRetrieveFaceListFromAPI.Text = "Retrieve";
            this.btnRetrieveFaceListFromAPI.UseVisualStyleBackColor = true;
            this.btnRetrieveFaceListFromAPI.Click += new System.EventHandler(this.btnRetrieveFaceListFromAPI_Click);
            // 
            // tpPersonGLInAPI
            // 
            this.tpPersonGLInAPI.Controls.Add(this.dgvPersonGroups);
            this.tpPersonGLInAPI.Location = new System.Drawing.Point(4, 22);
            this.tpPersonGLInAPI.Name = "tpPersonGLInAPI";
            this.tpPersonGLInAPI.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonGLInAPI.Size = new System.Drawing.Size(782, 307);
            this.tpPersonGLInAPI.TabIndex = 3;
            this.tpPersonGLInAPI.Text = "Person Groups";
            this.tpPersonGLInAPI.UseVisualStyleBackColor = true;
            // 
            // dgvPersonGroups
            // 
            this.dgvPersonGroups.AllowUserToAddRows = false;
            this.dgvPersonGroups.AllowUserToDeleteRows = false;
            this.dgvPersonGroups.AutoGenerateColumns = false;
            this.dgvPersonGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnDeletePersonGroup,
            this.dgvbtnViewPersonGroupDetails,
            this.personGroupIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvPersonGroups.DataSource = this.APIPersonGroupBindingSource;
            this.dgvPersonGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonGroups.Location = new System.Drawing.Point(3, 3);
            this.dgvPersonGroups.Name = "dgvPersonGroups";
            this.dgvPersonGroups.ReadOnly = true;
            this.dgvPersonGroups.Size = new System.Drawing.Size(776, 301);
            this.dgvPersonGroups.TabIndex = 0;
            this.dgvPersonGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonGroups_CellContentClick);
            // 
            // dgvbtnDeletePersonGroup
            // 
            this.dgvbtnDeletePersonGroup.HeaderText = "Delete";
            this.dgvbtnDeletePersonGroup.Name = "dgvbtnDeletePersonGroup";
            this.dgvbtnDeletePersonGroup.ReadOnly = true;
            this.dgvbtnDeletePersonGroup.Text = "Delete";
            // 
            // dgvbtnViewPersonGroupDetails
            // 
            this.dgvbtnViewPersonGroupDetails.HeaderText = "View Detail";
            this.dgvbtnViewPersonGroupDetails.Name = "dgvbtnViewPersonGroupDetails";
            this.dgvbtnViewPersonGroupDetails.ReadOnly = true;
            this.dgvbtnViewPersonGroupDetails.Text = "View Detail";
            // 
            // personGroupIdDataGridViewTextBoxColumn
            // 
            this.personGroupIdDataGridViewTextBoxColumn.DataPropertyName = "PersonGroupId";
            this.personGroupIdDataGridViewTextBoxColumn.HeaderText = "PersonGroupId";
            this.personGroupIdDataGridViewTextBoxColumn.Name = "personGroupIdDataGridViewTextBoxColumn";
            this.personGroupIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UserData";
            this.dataGridViewTextBoxColumn10.HeaderText = "UserData";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // APIPersonGroupBindingSource
            // 
            this.APIPersonGroupBindingSource.DataSource = typeof(Microsoft.ProjectOxford.Face.Contract.PersonGroup);
            // 
            // tpPersonInAPI
            // 
            this.tpPersonInAPI.Controls.Add(this.dgvPersons);
            this.tpPersonInAPI.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInAPI.Name = "tpPersonInAPI";
            this.tpPersonInAPI.Size = new System.Drawing.Size(782, 307);
            this.tpPersonInAPI.TabIndex = 4;
            this.tpPersonInAPI.Text = "Persons";
            this.tpPersonInAPI.UseVisualStyleBackColor = true;
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AutoGenerateColumns = false;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnDeletePerson,
            this.dgvbtnViewPersonDetails,
            this.personIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvPersons.DataSource = this.APIPersonBindingSource;
            this.dgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersons.Location = new System.Drawing.Point(0, 0);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.Size = new System.Drawing.Size(782, 307);
            this.dgvPersons.TabIndex = 0;
            // 
            // dgvbtnDeletePerson
            // 
            this.dgvbtnDeletePerson.HeaderText = "Delete";
            this.dgvbtnDeletePerson.Name = "dgvbtnDeletePerson";
            this.dgvbtnDeletePerson.ReadOnly = true;
            this.dgvbtnDeletePerson.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnDeletePerson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvbtnViewPersonDetails
            // 
            this.dgvbtnViewPersonDetails.HeaderText = "View Details";
            this.dgvbtnViewPersonDetails.Name = "dgvbtnViewPersonDetails";
            this.dgvbtnViewPersonDetails.ReadOnly = true;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "UserData";
            this.dataGridViewTextBoxColumn12.HeaderText = "UserData";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // APIPersonBindingSource
            // 
            this.APIPersonBindingSource.DataSource = typeof(Microsoft.ProjectOxford.Face.Contract.Person);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.tabFunctionsToolStripMenuItem,
            this.faceFindValidateToolStripMenuItem,
            this.personFindValidateToolStripMenuItem,
            this.unusedMenuItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolstripToolStripMenuItem,
            this.personGroupToolstripToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // personToolstripToolStripMenuItem
            // 
            this.personToolstripToolStripMenuItem.Checked = true;
            this.personToolstripToolStripMenuItem.CheckOnClick = true;
            this.personToolstripToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.personToolstripToolStripMenuItem.Name = "personToolstripToolStripMenuItem";
            this.personToolstripToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.personToolstripToolStripMenuItem.Text = "Person Toolstrip";
            // 
            // personGroupToolstripToolStripMenuItem
            // 
            this.personGroupToolstripToolStripMenuItem.Name = "personGroupToolstripToolStripMenuItem";
            this.personGroupToolstripToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.personGroupToolstripToolStripMenuItem.Text = "Person Group Toolstrip";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.encodeStringToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // encodeStringToolStripMenuItem
            // 
            this.encodeStringToolStripMenuItem.Name = "encodeStringToolStripMenuItem";
            this.encodeStringToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.encodeStringToolStripMenuItem.Text = "Encode String";
            this.encodeStringToolStripMenuItem.Click += new System.EventHandler(this.encodeStringToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tabFunctionsToolStripMenuItem
            // 
            this.tabFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faceToolStripMenuItem,
            this.faceListToolStripMenuItem,
            this.personGroupsToolStripMenuItem,
            this.personsToolStripMenuItem,
            this.refreshAllDataItemsToolStripMenuItem});
            this.tabFunctionsToolStripMenuItem.Name = "tabFunctionsToolStripMenuItem";
            this.tabFunctionsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tabFunctionsToolStripMenuItem.Text = "Data";
            // 
            // faceListToolStripMenuItem
            // 
            this.faceListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshFaceListToolStripMenuItem,
            this.createNewFaceListToolStripMenuItem,
            this.deleteFaceListToolStripMenuItem});
            this.faceListToolStripMenuItem.Name = "faceListToolStripMenuItem";
            this.faceListToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.faceListToolStripMenuItem.Text = "Face List";
            // 
            // refreshFaceListToolStripMenuItem
            // 
            this.refreshFaceListToolStripMenuItem.Name = "refreshFaceListToolStripMenuItem";
            this.refreshFaceListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.refreshFaceListToolStripMenuItem.Text = "&Refresh Face List";
            this.refreshFaceListToolStripMenuItem.Click += new System.EventHandler(this.refreshFaceListToolStripMenuItem_Click);
            // 
            // createNewFaceListToolStripMenuItem
            // 
            this.createNewFaceListToolStripMenuItem.Name = "createNewFaceListToolStripMenuItem";
            this.createNewFaceListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createNewFaceListToolStripMenuItem.Text = "Create New Face List";
            this.createNewFaceListToolStripMenuItem.Click += new System.EventHandler(this.createNewFaceListToolStripMenuItem_Click);
            // 
            // deleteFaceListToolStripMenuItem
            // 
            this.deleteFaceListToolStripMenuItem.Name = "deleteFaceListToolStripMenuItem";
            this.deleteFaceListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteFaceListToolStripMenuItem.Text = "&Delete Face List";
            this.deleteFaceListToolStripMenuItem.Click += new System.EventHandler(this.deleteFaceListToolStripMenuItem_Click);
            // 
            // personGroupsToolStripMenuItem
            // 
            this.personGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPersonGroupsToolStripMenuItem,
            this.createPersonGroupsToolStripMenuItem,
            this.deletePersonGroupToolStripMenuItem});
            this.personGroupsToolStripMenuItem.Name = "personGroupsToolStripMenuItem";
            this.personGroupsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.personGroupsToolStripMenuItem.Text = "Person Groups";
            // 
            // refreshPersonGroupsToolStripMenuItem
            // 
            this.refreshPersonGroupsToolStripMenuItem.Name = "refreshPersonGroupsToolStripMenuItem";
            this.refreshPersonGroupsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.refreshPersonGroupsToolStripMenuItem.Text = "&Refresh Person Groups";
            this.refreshPersonGroupsToolStripMenuItem.Click += new System.EventHandler(this.refreshPersonGroupsToolStripMenuItem_Click);
            // 
            // createPersonGroupsToolStripMenuItem
            // 
            this.createPersonGroupsToolStripMenuItem.Name = "createPersonGroupsToolStripMenuItem";
            this.createPersonGroupsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.createPersonGroupsToolStripMenuItem.Text = "&Create Person Group";
            this.createPersonGroupsToolStripMenuItem.Click += new System.EventHandler(this.createPersonGroupsToolStripMenuItem_Click);
            // 
            // deletePersonGroupToolStripMenuItem
            // 
            this.deletePersonGroupToolStripMenuItem.Name = "deletePersonGroupToolStripMenuItem";
            this.deletePersonGroupToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deletePersonGroupToolStripMenuItem.Text = "&Delete Person Group";
            this.deletePersonGroupToolStripMenuItem.Click += new System.EventHandler(this.deletePersonGroupToolStripMenuItem_Click);
            // 
            // personsToolStripMenuItem
            // 
            this.personsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPersonToolStripMenuItem,
            this.createPersonToolStripMenuItem1,
            this.deletePersonToolStripMenuItem});
            this.personsToolStripMenuItem.Name = "personsToolStripMenuItem";
            this.personsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.personsToolStripMenuItem.Text = "Persons";
            // 
            // refreshPersonToolStripMenuItem
            // 
            this.refreshPersonToolStripMenuItem.Name = "refreshPersonToolStripMenuItem";
            this.refreshPersonToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.refreshPersonToolStripMenuItem.Text = "Refresh Persons List";
            this.refreshPersonToolStripMenuItem.Click += new System.EventHandler(this.refreshPersonToolStripMenuItem_Click);
            // 
            // createPersonToolStripMenuItem1
            // 
            this.createPersonToolStripMenuItem1.Name = "createPersonToolStripMenuItem1";
            this.createPersonToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.createPersonToolStripMenuItem1.Text = "Create Person";
            this.createPersonToolStripMenuItem1.Click += new System.EventHandler(this.createPersonToolStripMenuItem1_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // refreshAllDataItemsToolStripMenuItem
            // 
            this.refreshAllDataItemsToolStripMenuItem.Name = "refreshAllDataItemsToolStripMenuItem";
            this.refreshAllDataItemsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.refreshAllDataItemsToolStripMenuItem.Text = "&Refresh All Data Items";
            this.refreshAllDataItemsToolStripMenuItem.Click += new System.EventHandler(this.refreshAllDataItemsToolStripMenuItem_Click);
            // 
            // faceFindValidateToolStripMenuItem
            // 
            this.faceFindValidateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findSimilarToolStripMenuItem,
            this.GroupFacesFromListofFacesToolStripMenuItem});
            this.faceFindValidateToolStripMenuItem.Name = "faceFindValidateToolStripMenuItem";
            this.faceFindValidateToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.faceFindValidateToolStripMenuItem.Text = "Face - Find/Validate";
            // 
            // findSimilarToolStripMenuItem
            // 
            this.findSimilarToolStripMenuItem.Name = "findSimilarToolStripMenuItem";
            this.findSimilarToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.findSimilarToolStripMenuItem.Text = "Find Similar";
            this.findSimilarToolStripMenuItem.Click += new System.EventHandler(this.findSimilarToolStripMenuItem_Click);
            // 
            // GroupFacesFromListofFacesToolStripMenuItem
            // 
            this.GroupFacesFromListofFacesToolStripMenuItem.Name = "GroupFacesFromListofFacesToolStripMenuItem";
            this.GroupFacesFromListofFacesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.GroupFacesFromListofFacesToolStripMenuItem.Text = "Group Faces from List of Faces";
            this.GroupFacesFromListofFacesToolStripMenuItem.Click += new System.EventHandler(this.GroupFacesFromListOfFacesToolStripMenuItem_Click);
            // 
            // personFindValidateToolStripMenuItem
            // 
            this.personFindValidateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verifyFaceBelongsToAPersonToolStripMenuItem,
            this.identifyFaceAmongAPersonGroupToolStripMenuItem});
            this.personFindValidateToolStripMenuItem.Name = "personFindValidateToolStripMenuItem";
            this.personFindValidateToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.personFindValidateToolStripMenuItem.Text = "Person - Find/Validate";
            // 
            // verifyFaceBelongsToAPersonToolStripMenuItem
            // 
            this.verifyFaceBelongsToAPersonToolStripMenuItem.Name = "verifyFaceBelongsToAPersonToolStripMenuItem";
            this.verifyFaceBelongsToAPersonToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.verifyFaceBelongsToAPersonToolStripMenuItem.Text = "Verify Face Belongs to a Person";
            this.verifyFaceBelongsToAPersonToolStripMenuItem.Click += new System.EventHandler(this.verifyFaceBelongsToAPersonToolStripMenuItem_Click);
            // 
            // identifyFaceAmongAPersonGroupToolStripMenuItem
            // 
            this.identifyFaceAmongAPersonGroupToolStripMenuItem.Name = "identifyFaceAmongAPersonGroupToolStripMenuItem";
            this.identifyFaceAmongAPersonGroupToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.identifyFaceAmongAPersonGroupToolStripMenuItem.Text = "Identify Face Among a Person Group";
            this.identifyFaceAmongAPersonGroupToolStripMenuItem.Click += new System.EventHandler(this.identifyFaceAmongAPersonGroupToolStripMenuItem_Click);
            // 
            // unusedMenuItemsToolStripMenuItem
            // 
            this.unusedMenuItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDatabaseToolStripMenuItem,
            this.refreshApiListToolStripMenuItem});
            this.unusedMenuItemsToolStripMenuItem.Enabled = false;
            this.unusedMenuItemsToolStripMenuItem.Name = "unusedMenuItemsToolStripMenuItem";
            this.unusedMenuItemsToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.unusedMenuItemsToolStripMenuItem.Text = "Unused Menu Items";
            this.unusedMenuItemsToolStripMenuItem.Visible = false;
            // 
            // refreshDatabaseToolStripMenuItem
            // 
            this.refreshDatabaseToolStripMenuItem.Name = "refreshDatabaseToolStripMenuItem";
            this.refreshDatabaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshDatabaseToolStripMenuItem.Text = "Refresh Database";
            this.refreshDatabaseToolStripMenuItem.Click += new System.EventHandler(this.refreshDatabaseToolStripMenuItem_Click);
            // 
            // refreshApiListToolStripMenuItem
            // 
            this.refreshApiListToolStripMenuItem.Name = "refreshApiListToolStripMenuItem";
            this.refreshApiListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshApiListToolStripMenuItem.Text = "Refresh Api List";
            this.refreshApiListToolStripMenuItem.Click += new System.EventHandler(this.refreshApiListToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(208, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // tsAPIPersonFunctions
            // 
            this.tsAPIPersonFunctions.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAPIPersonFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPersonRefresh,
            this.tsbtnPersonDelete});
            this.tsAPIPersonFunctions.Location = new System.Drawing.Point(10, 49);
            this.tsAPIPersonFunctions.Name = "tsAPIPersonFunctions";
            this.tsAPIPersonFunctions.Size = new System.Drawing.Size(140, 25);
            this.tsAPIPersonFunctions.TabIndex = 2;
            this.tsAPIPersonFunctions.Text = "API Persons Functions";
            // 
            // tsbtnPersonRefresh
            // 
            this.tsbtnPersonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPersonRefresh.Image")));
            this.tsbtnPersonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPersonRefresh.Name = "tsbtnPersonRefresh";
            this.tsbtnPersonRefresh.Size = new System.Drawing.Size(105, 22);
            this.tsbtnPersonRefresh.Text = "Refresh Person";
            // 
            // tsbtnPersonDelete
            // 
            this.tsbtnPersonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPersonDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPersonDelete.Image")));
            this.tsbtnPersonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPersonDelete.Name = "tsbtnPersonDelete";
            this.tsbtnPersonDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPersonDelete.Text = "Delete Person";
            this.tsbtnPersonDelete.ToolTipText = "Delete Selected Person (by row/cell)";
            // 
            // faceListToolStripMenuItem1
            // 
            this.faceListToolStripMenuItem1.Name = "faceListToolStripMenuItem1";
            this.faceListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.faceListToolStripMenuItem1.Text = "Face Lists";
            // 
            // personGroupsToolStripMenuItem1
            // 
            this.personGroupsToolStripMenuItem1.Name = "personGroupsToolStripMenuItem1";
            this.personGroupsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.personGroupsToolStripMenuItem1.Text = "Person Groups";
            // 
            // persistedFaceIdsBindingSource
            // 
            this.persistedFaceIdsBindingSource.DataMember = "PersistedFaceIds";
            this.persistedFaceIdsBindingSource.DataSource = this.DatabasePersonBindingSource;
            // 
            // faceToolStripMenuItem
            // 
            this.faceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterFaceIntoDatabaseToolStripMenuItem});
            this.faceToolStripMenuItem.Name = "faceToolStripMenuItem";
            this.faceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.faceToolStripMenuItem.Text = "Face";
            // 
            // enterFaceIntoDatabaseToolStripMenuItem
            // 
            this.enterFaceIntoDatabaseToolStripMenuItem.Name = "enterFaceIntoDatabaseToolStripMenuItem";
            this.enterFaceIntoDatabaseToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.enterFaceIntoDatabaseToolStripMenuItem.Text = "Enter Face Into Database";
            this.enterFaceIntoDatabaseToolStripMenuItem.Click += new System.EventHandler(this.enterFaceIntoDatabaseToolStripMenuItem_Click);
            // 
            // frmFaceDBData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFaceDBData";
            this.Text = "Face Data Manager";
            this.Load += new System.EventHandler(this.frmFaceDBData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagesInDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFaceBindingSource)).EndInit();
            this.cmsFaceAttributes.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlDataSections.ResumeLayout(false);
            this.tpDatabaseSection.ResumeLayout(false);
            this.tabControlDatabase.ResumeLayout(false);
            this.tpImageInDB.ResumeLayout(false);
            this.tpFaceLInDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaceListInDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFaceListBindingSource)).EndInit();
            this.tpPersonGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabasePersonGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePersonGroupBindingSource)).EndInit();
            this.tpPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabasePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePersonBindingSource)).EndInit();
            this.tpAPIDataSection.ResumeLayout(false);
            this.tabControlAPIData.ResumeLayout(false);
            this.tpFaceLInAPI.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaceAPIFaceLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIFaceListMetadataBindingSource)).EndInit();
            this.tpPersonGLInAPI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIPersonGroupBindingSource)).EndInit();
            this.tpPersonInAPI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIPersonBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tsAPIPersonFunctions.ResumeLayout(false);
            this.tsAPIPersonFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persistedFaceIdsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImagesInDb;
        private System.Windows.Forms.ContextMenuStrip cmsFaceAttributes;
        private System.Windows.Forms.ToolStripMenuItem reviewAllAttributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewFaceListToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TabControl tabControlDatabase;
        private System.Windows.Forms.TabPage tpImageInDB;
        private System.Windows.Forms.TabPage tpFaceLInDB;
        private System.Windows.Forms.TabPage tpFaceLInAPI;
        private System.Windows.Forms.DataGridView dgvFaceListInDB;
        private System.Windows.Forms.DataGridView dgvFaceAPIFaceLists;
        private System.Windows.Forms.ToolStripMenuItem encodeStringToolStripMenuItem;
        private System.Windows.Forms.Button btnRetrieveFaceListFromAPI;
        private System.Windows.Forms.ToolStripMenuItem refreshDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshApiListToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceListIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tpPersonGLInAPI;
        private System.Windows.Forms.TabPage tpPersonInAPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemIDdgvtxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceIDdgbtxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceAttributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceRectangleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bitmapImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageBytesDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnShowFaceListDetails;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnRemoveFaceList;
        private System.Windows.Forms.TabControl tabControlDataSections;
        private System.Windows.Forms.TabPage tpDatabaseSection;
        private System.Windows.Forms.TabPage tpAPIDataSection;
        private System.Windows.Forms.TabControl tabControlAPIData;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personToolstripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personGroupToolstripToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsAPIPersonFunctions;
        private System.Windows.Forms.ToolStripButton tsbtnPersonRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnPersonDelete;
        private System.Windows.Forms.ToolStripMenuItem personGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPersonGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPersonGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personGroupsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem refreshPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPersonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceFindValidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personFindValidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshFaceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFaceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findSimilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GroupFacesFromListofFacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyFaceBelongsToAPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unusedMenuItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAllDataItemsToolStripMenuItem;
        private System.Windows.Forms.BindingSource DatabaseFaceBindingSource;
        private System.Windows.Forms.BindingSource DatabaseFaceListBindingSource;
        private System.Windows.Forms.DataGridView dgvPersonGroups;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnDeletePersonGroup;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnViewPersonGroupDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGroupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource DatabasePersonGroupBindingSource;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnDeletePerson;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnViewPersonDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource APIFaceListMetadataBindingSource;
        private System.Windows.Forms.TabPage tpPersonGroups;
        private System.Windows.Forms.DataGridView dgvDatabasePersonGroups;
        private System.Windows.Forms.TabPage tpPerson;
        private System.Windows.Forms.DataGridView dgvDatabasePersons;
        private System.Windows.Forms.BindingSource APIPersonGroupBindingSource;
        private System.Windows.Forms.BindingSource APIPersonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemPersonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource DatabasePersonBindingSource;
        private System.Windows.Forms.BindingSource persistedFaceIdsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem identifyFaceAmongAPersonGroupToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn ResendToDetect;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnAddToCurrentFaceList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaceListPersistantIDtxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLastDetected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceLandmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectangleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceListPersistantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facePersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLastDetectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedToFaceListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedToPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedToPersonGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnDeleteRowAndFaceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn addeDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonGroupNameDGVtxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ToolStripMenuItem faceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterFaceIntoDatabaseToolStripMenuItem;
    }
}