namespace Face_Recognition_Debug_Application
{
    partial class frmEncodeServiceKey
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEncodeString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncodedKey = new System.Windows.Forms.TextBox();
            this.btnCopyEncodedToBuffer = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEncodeString
            // 
            this.btnEncodeString.Location = new System.Drawing.Point(421, 64);
            this.btnEncodeString.Name = "btnEncodeString";
            this.btnEncodeString.Size = new System.Drawing.Size(75, 23);
            this.btnEncodeString.TabIndex = 1;
            this.btnEncodeString.Text = "Encode String";
            this.btnEncodeString.UseVisualStyleBackColor = true;
            this.btnEncodeString.Click += new System.EventHandler(this.btnEncodeString_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service Key";
            // 
            // txtServiceKey
            // 
            this.txtServiceKey.Location = new System.Drawing.Point(89, 6);
            this.txtServiceKey.Name = "txtServiceKey";
            this.txtServiceKey.Size = new System.Drawing.Size(488, 20);
            this.txtServiceKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encoded Key";
            // 
            // txtEncodedKey
            // 
            this.txtEncodedKey.Location = new System.Drawing.Point(89, 38);
            this.txtEncodedKey.Name = "txtEncodedKey";
            this.txtEncodedKey.Size = new System.Drawing.Size(407, 20);
            this.txtEncodedKey.TabIndex = 5;
            // 
            // btnCopyEncodedToBuffer
            // 
            this.btnCopyEncodedToBuffer.Location = new System.Drawing.Point(502, 35);
            this.btnCopyEncodedToBuffer.Name = "btnCopyEncodedToBuffer";
            this.btnCopyEncodedToBuffer.Size = new System.Drawing.Size(75, 23);
            this.btnCopyEncodedToBuffer.TabIndex = 6;
            this.btnCopyEncodedToBuffer.Text = "Copy";
            this.btnCopyEncodedToBuffer.UseVisualStyleBackColor = true;
            this.btnCopyEncodedToBuffer.Click += new System.EventHandler(this.btnCopyEncodedToBuffer_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 7;
            // 
            // frmEncodeServiceKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 95);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCopyEncodedToBuffer);
            this.Controls.Add(this.txtEncodedKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncodeString);
            this.Controls.Add(this.button1);
            this.Name = "frmEncodeServiceKey";
            this.Text = "frmEncodeServiceKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEncodeString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncodedKey;
        private System.Windows.Forms.Button btnCopyEncodedToBuffer;
        private System.Windows.Forms.Label lblStatus;
    }
}