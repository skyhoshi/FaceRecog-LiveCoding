using System.Windows.Forms;

namespace Facial_Recognition_Library.Controls
{
    public class DataGridViewMethods
    {
        public static DataGridViewColumn GetDataGridViewColumnFromDataGridViewByColumnIndexId(ref object sender, int ColumnIndex)
        {
            if (sender is DataGridView dgv)
                return dgv.Columns[ColumnIndex];
            else
            {
                return null;
            }

        }
    }
}