using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Recognition_Debug_Application.Forms.Person
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        public string strPersonGroupId { get; set; }

        public string strPersonName { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            strPersonGroupId = comboBox1.SelectedValue.ToString();
            strPersonName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Hide();
            //DO NOT CLOSE THIS FORM HERE ONLY HIDE!!! your data will go missing and throw and error

        }
    }
}
