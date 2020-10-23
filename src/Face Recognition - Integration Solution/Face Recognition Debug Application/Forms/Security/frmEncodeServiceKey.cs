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
    public partial class frmEncodeServiceKey : Form
    {
        public frmEncodeServiceKey()
        {
            InitializeComponent();
            statusTimer.Tick += (sender, args) => { lblStatus.Text = ""; };
        }

        private Timer statusTimer { get; set; } = new Timer { Interval = 4000, Enabled = true };

        private void btnEncodeString_Click(object sender, EventArgs e)
        {
            txtEncodedKey.Text = Facial_Recognition_Library.Crypto.EncryptedStringAES(txtServiceKey.Text);
        }

        private void btnCopyEncodedToBuffer_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtEncodedKey.Text);
                lblStatus.Text = $@"Encoded Key Copied to clipboard";
            }
            catch (Exception exception)
            {
                lblStatus.Text = $@"Failed to copy Encoded Key to clipboard";
            }
            
            
        }
    }
}
