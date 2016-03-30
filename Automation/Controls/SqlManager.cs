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

        private void T_CreateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog OpF = new SaveFileDialog();

            //OpF.DefaultExt = ".rep";
            if (OpF.ShowDialog() == DialogResult.OK)
            {
                DBFilePath = OpF.FileName;
                createdbfile(DBFilePath, false);
            }
            
        }

        private void T_ExecuteQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(QueryPannel.SelectedText))
                {
                    executequery(QueryPannel.SelectedText);
                }
                else
                {
                    executequery(QueryPannel.Text);
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
    }
}
