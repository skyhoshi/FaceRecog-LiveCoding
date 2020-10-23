using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Recognition_Debug_Application.Forms.PersonGroup
{
    public partial class frmPersonGroup : Form
    {
        public frmPersonGroup()
        {
            InitializeComponent();
        }

        public string strPersonGroupName { get; set; }
        public string strPersonGroupID { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strPersonGroupName = txtPersonGroupName.Text;
            strPersonGroupID = txtPersonGroupId.Text.ToLower();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }


        private void txtPersonGroupId_TextChanged(object sender, EventArgs e)
        {
            txtPersonGroupId.Text = txtPersonGroupId.Text.ToLower();
        }
    }
}
