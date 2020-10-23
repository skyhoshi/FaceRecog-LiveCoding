using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Facial_Recognition_Library.Controls
{
    public static class DataGridViewUtilities
    {
        public static bool IsARowSelected(DataGridView DataGridView)
        {
            return DataGridView.SelectedRows.Count > 0;
        }

        public static bool IsARowSelected(DataGridView DataGridView, out DataGridViewRow selectedRow)
        {
            selectedRow = DataGridView.SelectedRows[0];
            return IsARowSelected(DataGridView);
        }
    }
}
