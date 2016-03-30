using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite
    using System.Data;

namespace Automation.Classes
{

    public  class RepositoryManager
    {
        private String DBFilePath;
        public RepositoryManager(String RepositoryPath)
        {
            DBFilePath = RepositoryPath;
        }
        public  void InsertNewScreen(String ScreenName, String FrameProperty)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBFilePath + ";Version=3;");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand("insert into ScreenRepository (ScreenName,FrameProperty) values ('" + ScreenName +"','" + FrameProperty + "');", conn);
            command.ExecuteNonQuery();
            command = null;
            conn.Close();
        }
        internal DataTable GetData(String SqlQuery)
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
                throw new Exception(e.Message;
            }

            return DT;
        }

    }
}
