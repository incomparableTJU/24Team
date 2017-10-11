using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanTool
{
    public partial class Form1 : Form
    {
        private DataTable _dtEmployees;
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this._dtEmployees = this.CreateDataTable();

            // Call the BuildTree method to build the TreeView.
            CreateTreeViewFormTable.BuildTree(
                this._dtEmployees, this.treeView1,
                true, "LastName", "EmployeeID", "ReportsTo");
        }

        public DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            // The value in this column will identify the TreeNode
            dataTable.Columns.Add("EmployeeID");

            // The value in this column will display on the TreeNode
            dataTable.Columns.Add("LastName");

            // The value in this column will identify its parentId 
            dataTable.Columns.Add("ReportsTo");

            // Fill the DataTable
            dataTable.Rows.Add(1, "Davolio", 2);
            dataTable.Rows.Add(2, "Fuller", DBNull.Value);
            dataTable.Rows.Add(3, "Leverling", 2);
            dataTable.Rows.Add(4, "Peacock", 2);
            dataTable.Rows.Add(5, "Buchanan", 2);
            dataTable.Rows.Add(6, "Suyama", 5);
            dataTable.Rows.Add(7, "King", 5);
            dataTable.Rows.Add(8, "Callahan", 2);
            dataTable.Rows.Add(9, "Dodsworth", 5);
            return dataTable;
        }
    }
}
