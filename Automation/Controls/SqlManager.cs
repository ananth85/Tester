using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Automation.Classes;
namespace Automation.Controls
{
    public partial class SqlManager : UserControl
    {
     
        public String DBFilePath { get; set; }
        public SqlManager()
        {
            InitializeComponent();
        }
        internal void createdbfile(string DBFilepath, bool extension)
        {
            SQLiteConnection.CreateFile(DBFilePath);
        }
        internal void executequery(String SqlQuery)
        {

            SQLiteConnection Conn = new SQLiteConnection("Data Source=" + DBFilePath + ";Version=3;");
            Conn.Open();
            SQLiteCommand command = new SQLiteCommand(SqlQuery, Conn);
            command.ExecuteNonQuery();


        }
        internal DataTable executeQuerytoDatagrid(String SqlQuery)
        {
            RepositoryManager RP = new RepositoryManager(DBFilePath);
            return RP.GetData(SqlQuery);


        }
        private void T_CreateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog OpF = new SaveFileDialog();

            //OpF.DefaultExt = ".rep";
            if (OpF.ShowDialog() == DialogResult.OK)
            {
                DBFilePath = OpF.FileName;
                createdbfile(DBFilePath, false);
                DatabaseStructure.Nodes.Clear();
                DatabaseStructure.Nodes.Add(Automation.Classes.StaticRepositoryClassManager.ReadDbStructure(DBFilePath));

            }

        }

        private void T_ExecuteQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(QueryPannel.SelectedText))
                {
                   if( QueryPannel.SelectedText.Trim().Substring(0,6).ToLower() == "select")
                    {
                        ResultGridView.DataSource = null;
                        ResultGridView.DataSource = executeQuerytoDatagrid(QueryPannel.SelectedText);
                    }
                   else
                    executequery(QueryPannel.SelectedText);
                }
                else
                {
                    if (!String.IsNullOrEmpty(QueryPannel.Text))
                    {
                        if (QueryPannel.Text.Trim().Substring(0, 6).ToLower() == "select")
                        {
                            ResultGridView.DataSource = null;
                            ResultGridView.DataSource = executeQuerytoDatagrid(QueryPannel.Text);
                        }
                        else
                            executequery(QueryPannel.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void T_SaveQuery_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
           
                SFD.DefaultExt = ".sql";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
 
                File.WriteAllText(SFD.FileName, QueryPannel.Text);
            }
        }

        private void T_LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if(OPF.ShowDialog()==DialogResult.OK)
            {
                DBFilePath = OPF.FileName;
                DatabaseStructure.Nodes.Clear();
                DatabaseStructure.Nodes.Add(Automation.Classes.StaticRepositoryClassManager.ReadDbStructure(DBFilePath));
            }
        }

        private void QueryPannel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                if (!string.IsNullOrEmpty(QueryPannel.SelectedText))
                {
                    ResultGridView.DataSource = null;
                    ResultGridView.DataSource = executeQuerytoDatagrid("Select * from " + QueryPannel.SelectedText);
                }
            }
        }

        private void DatabaseStructure_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Text))
            {
                ResultGridView.DataSource = null;
                ResultGridView.DataSource = executeQuerytoDatagrid("Select * from " + e.Node.Text);
            }
        }
    }
}
