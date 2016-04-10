using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
namespace Automation.Classes
{
    public static class StaticRepositoryClassManager
    {
        public static TreeNode ReadDbStructure(String DBFilePath)
        {
            String dbfolder = Path.GetFileNameWithoutExtension(DBFilePath);
            TreeNode PTN = new TreeNode(dbfolder,0,0);
            TreeNode TN = PTN.Nodes.Add("Tables","Tables",1,1);
            String SqlQueryTables= "SELECT name FROM sqlite_master WHERE type = 'table'";
            DataTable TempDT = GetData(DBFilePath, SqlQueryTables);
            foreach (DataRow Dr in TempDT.Rows)
            {
                TN.Nodes.Add(Dr["name"].ToString(), Dr["name"].ToString(),2,2);
            }
             TN = PTN.Nodes.Add("Views","Views",1,1);
             SqlQueryTables = "SELECT name FROM sqlite_master WHERE type = 'view'";
             TempDT = GetData(DBFilePath, SqlQueryTables);
            foreach (DataRow Dr in TempDT.Rows)
            {
                TN.Nodes.Add(Dr["name"].ToString(), Dr["name"].ToString(), 3, 3);
            }
            return PTN;
        }

        internal static DataTable GetData(String DBFilePath, String SqlQuery)
        {
            DataTable DT = new DataTable();
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBFilePath + ";Version=3;");
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(SqlQuery, conn);
                SQLiteDataReader DR = command.ExecuteReader();
                DT.Load(DR);
                DR.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return DT;
        }
    }
}
