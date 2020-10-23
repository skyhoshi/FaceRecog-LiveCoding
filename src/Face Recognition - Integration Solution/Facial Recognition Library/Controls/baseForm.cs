using System;

namespace Facial_Recognition_Library.Controls
{
    /// <summary>
    /// Form DATA processing method. 
    /// </summary>
    public abstract class baseForm : System.Windows.Forms.Form
    {
        public delegate void FormDataRefresh();

        public delegate void FormDataApiRefresh();

        public delegate void FormDataAllRefresh();

        public event FormDataRefresh DataFormRefresh;

        public event FormDataApiRefresh DataApiFormRefresh;

        public event FormDataAllRefresh DataAllFormRefresh;

        public void ProcessDataGridViewResult(DataGridViewsProcessResult dgvResult)
        {
            if (dgvResult.Success)
            {
                if (dgvResult.ShouldRefreshAPIDataGrids && dgvResult.ShouldRefreshDatabaseDataGrids)
                {
                    if (DataAllFormRefresh != null)
                    {
                        DataAllFormRefresh?.Invoke();
                    }
                    else
                    {
                        //Alert that there's no event handler. 
                        System.Diagnostics.Debug.WriteLine("Data Form ALL has no handler. so the event fired but nothing happened.");
                    }
                }
                else
                {

                    if (dgvResult.ShouldRefreshAPIDataGrids)
                    {
                        if (DataApiFormRefresh != null)
                        {
                            DataApiFormRefresh?.Invoke();
                        }
                        else
                        {
                            //Alert that there's no event handler. 
                            System.Diagnostics.Debug.WriteLine("Data Form API has no handler. so the event fired but nothing happened.");
                        }
                    }

                    if (dgvResult.ShouldRefreshDatabaseDataGrids)
                    {
                        if (DataFormRefresh != null)
                        {
                            DataFormRefresh?.Invoke();
                        }
                        else
                        {
                            //Alert that there's no event handler. 
                            System.Diagnostics.Debug.WriteLine("Data Form Refresh has no handler. so the event fired but nothing happened.");
                        }
                    }
                }
                //this was intended for processing individual controls on pages (such as textboxes outside of a grid, or the Status label.)
                //TODO: Include the Status Label update for processing.
                //foreach (var ControlName in dgvResult.loControlsToRefresh)
                //{
                //    if (this.Controls.ContainsKey(ControlName))
                //    {
                //    }
                //}
            }

        }
    }

    /// <inheritdoc />
    public class PrimaryForm : baseForm
    {

    }
}
