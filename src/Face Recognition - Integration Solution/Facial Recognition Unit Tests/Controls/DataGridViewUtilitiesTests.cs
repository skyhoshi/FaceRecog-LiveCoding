using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facial_Recognition_Library.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facial_Recognition_Library.Controls.Tests
{
    [TestClass()]
    public class DataGridViewUtilitiesTests
    {
        private System.Windows.Forms.DataGridView testDataGridView { get; set; }

        //private DataGridViewColumnCollection dgvcc { get; set; }

        [TestInitialize()]
        public void Setup()
        {
            if (testDataGridView == null)
            {
                testDataGridView = new DataGridView();
                testDataGridView.AllowUserToAddRows = false;
            }

            if (testDataGridView.ColumnCount == 0)
            {
                DataGridViewColumn FirstColumn = new DataGridViewColumn();
                FirstColumn.HeaderText = $@"First Column";
                FirstColumn.CellTemplate = new DataGridViewTextBoxCell();
                DataGridViewColumn SecondColumn = new DataGridViewColumn();
                SecondColumn.HeaderText = $@"Second Column";
                SecondColumn.CellTemplate = new DataGridViewTextBoxCell();
                //dgvcc = new DataGridViewColumnCollection(testDataGridView); //{{ "First Column", "First Column Header" },{ "Second Column", "Second Column Header" }};
                //dgvcc.Add(FirstColumn);
                //dgvcc.Add(SecondColumn);
                testDataGridView.Columns.Add(FirstColumn);
                testDataGridView.Columns.Add(SecondColumn);
            }

            if (testDataGridView.RowCount == 0)
            {
                DataGridViewRow dgViewRow = new DataGridViewRow();
                //dgViewRow.CreateCells(testDataGridView,);
                testDataGridView.Rows.Add(new object[] { "Test 1 Column 1", "Test 1 Column 2" });
                testDataGridView.Rows.Add(new object[] { "Test 2 Column 1", "Test 2 Column 2" });
                testDataGridView.Rows.Add(new object[] { "Test 3 Column 1", "Test 3 Column 2" });
                testDataGridView.Rows.Add(new object[] { "Test 4 Column 1", "Test 4 Column 2" });
                //testDataGridView.Rows.Add(dgViewRow);
            }
        }

        [TestMethod()]
        public void IsARowSelectedTest()
        {
            testDataGridView.Rows[0].Selected = true;
            if (Facial_Recognition_Library.Controls.DataGridViewUtilities.IsARowSelected(testDataGridView))
            {
                System.Diagnostics.Debug.Print($"Contents of selected row : {testDataGridView.SelectedRows[0].Cells[0].Value.ToString()}");
            }
            else
            {
                Assert.Fail("something wasn't passed correctly. try again.");
            }
        }

        [TestMethod()]
        public void IsARowSelectedOutSelectedRowTest()
        {
            //Take Last Row
            int RowToSelect = testDataGridView.RowCount - 1;
            Assert.IsTrue(testDataGridView.RowCount > 1, "!testDataGridView.RowCount > 1");
            testDataGridView.Rows[RowToSelect].Selected = true;
            if (Facial_Recognition_Library.Controls.DataGridViewUtilities.IsARowSelected(testDataGridView, out DataGridViewRow selectedRow))
            {
                if (selectedRow != null)
                {
                    System.Diagnostics.Debug.Print($"Contents of selected row : {selectedRow.Cells[0].Value.ToString()}");
                }
                else
                {
                    Assert.Fail("Selected Row is Null");
                }
            }
            else
            {
                Assert.Fail("something wasn't passed correctly. try again.");
            }
        }
    }
}