namespace Face_Recognition_Debug_Application
{
    partial class frmCreateNewFaceList
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
            this.btnCreateFaceList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaceListID = new System.Windows.Forms.TextBox();
            this.txtFaceListName = new System.Windows.Forms.TextBox();
            this.txtFaceUserData = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFaceList
            // 
            this.btnCreateFaceList.Location = new System.Drawing.Point(52, 111);
            this.btnCreateFaceList.Name = "btnCreateFaceList";
            this.btnCreateFaceList.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFaceList.TabIndex = 0;
            this.btnCreateFaceList.Text = "Create";
            this.btnCreateFaceList.UseVisualStyleBackColor = true;
            this.btnCreateFaceList.Click += new System.EventHandler(this.btnCreateFaceList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Face List ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Face List Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Extra User Data";
            // 
            // txtFaceListID
            // 
            this.txtFaceListID.Location = new System.Drawing.Point(121, 33);
            this.txtFaceListID.Name = "txtFaceListID";
            this.txtFaceListID.Size = new System.Drawing.Size(100, 20);
            this.txtFaceListID.TabIndex = 4;
            // 
            // txtFaceListName
            // 
            this.txtFaceListName.Location = new System.Drawing.Point(121, 59);
            this.txtFaceListName.Name = "txtFaceListName";
            this.txtFaceListName.Size = new System.Drawing.Size(100, 20);
            this.txtFaceListName.TabIndex = 5;
            // 
            // txtFaceUserData
            // 
            this.txtFaceUserData.Location = new System.Drawing.Point(121, 85);
            this.txtFaceUserData.Name = "txtFaceUserData";
            this.txtFaceUserData.Size = new System.Drawing.Size(100, 20);
            this.txtFaceUserData.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateNewFaceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 157);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFaceUserData);
            this.Controls.Add(this.txtFaceListName);
            this.Controls.Add(this.txtFaceListID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateFaceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateNewFaceList";
            this.Text = "Create New Face List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFaceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFaceListID;
        private System.Windows.Forms.TextBox txtFaceListName;
        private System.Windows.Forms.TextBox txtFaceUserData;
        private System.Windows.Forms.Button btnCancel;
    }
}