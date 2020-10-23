namespace Face_Recognition_Debug_Application.Forms.FaceList
{
    partial class frmShowFaceListDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.persistedFaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personFaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personFaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persistedFaceIdDataGridViewTextBoxColumn,
            this.userDataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personFaceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(976, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // persistedFaceIdDataGridViewTextBoxColumn
            // 
            this.persistedFaceIdDataGridViewTextBoxColumn.DataPropertyName = "PersistedFaceId";
            this.persistedFaceIdDataGridViewTextBoxColumn.HeaderText = "PersistedFaceId";
            this.persistedFaceIdDataGridViewTextBoxColumn.Name = "persistedFaceIdDataGridViewTextBoxColumn";
            this.persistedFaceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataDataGridViewTextBoxColumn
            // 
            this.userDataDataGridViewTextBoxColumn.DataPropertyName = "UserData";
            this.userDataDataGridViewTextBoxColumn.HeaderText = "UserData";
            this.userDataDataGridViewTextBoxColumn.Name = "userDataDataGridViewTextBoxColumn";
            this.userDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personFaceBindingSource
            // 
            this.personFaceBindingSource.DataSource = typeof(Microsoft.ProjectOxford.Face.Contract.PersonFace);
            // 
            // frmShowFaceListDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 497);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmShowFaceListDetails";
            this.Text = "Face List Details : Persistant Faces by ID";
            this.Shown += new System.EventHandler(this.frmShowFaceListDetails_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personFaceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn persistedFaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personFaceBindingSource;
    }
}