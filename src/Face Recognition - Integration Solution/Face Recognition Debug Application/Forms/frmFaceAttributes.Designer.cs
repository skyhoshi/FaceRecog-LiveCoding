namespace Face_Recognition_Debug_Application
{
    partial class frmFaceAttributes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbllblSystemID = new System.Windows.Forms.Label();
            this.lblSystemID = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 248);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbllblSystemID
            // 
            this.lbllblSystemID.AutoSize = true;
            this.lbllblSystemID.Location = new System.Drawing.Point(13, 13);
            this.lbllblSystemID.Name = "lbllblSystemID";
            this.lbllblSystemID.Size = new System.Drawing.Size(61, 13);
            this.lbllblSystemID.TabIndex = 1;
            this.lbllblSystemID.Text = "System ID: ";
            // 
            // lblSystemID
            // 
            this.lblSystemID.AutoSize = true;
            this.lblSystemID.Location = new System.Drawing.Point(81, 13);
            this.lblSystemID.Name = "lblSystemID";
            this.lblSystemID.Size = new System.Drawing.Size(0, 13);
            this.lblSystemID.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(399, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(213, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Tag = "Does this image have more than one detectable face?";
            this.checkBox1.Text = "Has Multiple People within the Picutre? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmFaceAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 469);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSystemID);
            this.Controls.Add(this.lbllblSystemID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFaceAttributes";
            this.Text = "frmFaceAttributes";
            this.Load += new System.EventHandler(this.frmFaceAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbllblSystemID;
        private System.Windows.Forms.Label lblSystemID;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}