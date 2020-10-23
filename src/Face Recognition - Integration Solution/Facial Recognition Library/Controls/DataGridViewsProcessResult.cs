using System.Collections.Generic;

namespace Facial_Recognition_Library.Controls
{
    public class DataGridViewsProcessResult
    {
        public bool Success { get; set; }
        public bool ShouldRefreshDatabaseDataGrids { get; set; }
        public bool ShouldRefreshAPIDataGrids { get; set; }

        public List<string> loControlsToRefresh { get; set; }
        public string Reason { get; set; }
    }
}