using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Cantool
{
    public partial class TreeForm : Form
    {
        private DataTable _dtEmployees;
        public List<Message> database = new List<Message>();

        public string[,] signal = new string[20, 100];
        public List<string> messagename = new List<string>();
        public Signal[,] signalname = new Signal[20, 100];
        public TreeForm()
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
            dataTable.Rows.Add(0, "读取的数据", DBNull.Value);
            int num = 1;
            for (int i = 0; i < messagename.Count(); i++)
            {
                dataTable.Rows.Add(num, messagename[i], 0);
                num++;
            }
            for (int i = 0; i < messagename.Count(); i++)
            {
                for (int j = 0; signal[i, j] != null; j++)
                {
                    dataTable.Rows.Add(num, signalname[i, j].signalName, i + 1);
                    num++;
                }

            }
            return dataTable;
        }

        //get all messages from fileSaver form
        public void loadData(List<Message> dbs)
        {
           if(dbs.Count()==0)
               MessageBox.Show("请先加载数据");
          else
          {
                database = dbs;         
                for (int i = 0; i < database.Count(); i++)
                {
                    messagename.Add(database[i].messageName);
                    for (int j = 0; j < database[i].signals.Count(); j++)
                    {
                        signal[i, j] = database[i].signals[j];
                        signalname[i, j] = Signal.getSignal(signal[i, j]);
                    }
                }
            }
           
                
           
        }
    }
}