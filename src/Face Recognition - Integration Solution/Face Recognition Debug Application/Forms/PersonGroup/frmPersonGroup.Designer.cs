namespace Face_Recognition_Debug_Application.Forms.PersonGroup
{
    partial class frmPersonGroup
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPersonGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonGroupId = new System.Windows.Forms.TextBox();
            this.cbxGenerateID = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 58);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPersonGroupName
            // 
            this.txtPersonGroupName.Location = new System.Drawing.Point(121, 6);
            this.txtPersonGroupName.MaxLength = 128;
            this.txtPersonGroupName.Name = "txtPersonGroupName";
            this.txtPersonGroupName.Size = new System.Drawing.Size(301, 20);
            this.txtPersonGroupName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Group Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Person Group ID";
            // 
            // txtPersonGroupId
            // 
            this.txtPersonGroupId.Location = new System.Drawing.Point(121, 32);
            this.txtPersonGroupId.Name = "txtPersonGroupId";
            this.txtPersonGroupId.Size = new System.Drawing.Size(173, 20);
            this.txtPersonGroupId.TabIndex = 4;
            this.txtPersonGroupId.TextChanged += new System.EventHandler(this.txtPersonGroupId_TextChanged);
            // 
            // cbxGenerateID
            // 
            this.cbxGenerateID.AutoSize = true;
            this.cbxGenerateID.Location = new System.Drawing.Point(300, 35);
            this.cbxGenerateID.Name = "cbxGenerateID";
            this.cbxGenerateID.Size = new System.Drawing.Size(122, 17);
            this.cbxGenerateID.TabIndex = 5;
            this.cbxGenerateID.Text = "Generate Custom ID";
            this.cbxGenerateID.UseVisualStyleBackColor = true;
            // 
            // frmPersonGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 100);
            this.Controls.Add(this.cbxGenerateID);
            this.Controls.Add(this.txtPersonGroupId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonGroupName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmPersonGroup";
            this.Text = "Person Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPersonGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonGroupId;
        private System.Windows.Forms.CheckBox cbxGenerateID;
    }
}