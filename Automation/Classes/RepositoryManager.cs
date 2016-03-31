using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
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
        public void InsertNewScreen(String ScreenName, String FrameProperty)
        {
            String SqlQuery = "Select * from ScreenRepository where ScreenName ='" + ScreenName + "'";
            if (GetData(SqlQuery).Rows.Count == 0)
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBFilePath + ";Version=3;");
                conn.Open();
                SQLiteCommand command = new SQLiteCommand("insert into ScreenRepository (ScreenName,FrameProperty) values ('" + ScreenName + "','" + FrameProperty + "');", conn);
                command.ExecuteNonQuery();
                command = null;
                conn.Close();
            }
            else
                throw new Exception("Screen already exists in the database");
         }
        public  void InsertNewObject(String ScreenName,String ObjectName, String ObjBy, String ObjProp ,String ObjDesc)
        {
            String SqlQuery = "Select ScreenID,ScreenName from ScreenRepository where ScreenName ='" + ScreenName + "'";
            DataRowCollection ScreenRows = GetData(SqlQuery).Rows;
            SQLiteConnection conn;
            if (ScreenRows.Count == 1)
            {
                String SqlOnjectEx = "Select count(*) countrows from ObjectRepository where ScreenID = '" + ScreenRows[1]["ScreenID"];
                conn = new SQLiteConnection("Data Source=" + DBFilePath + ";Version=3;");
                conn.Open();
                if (GetData(SqlOnjectEx).Rows[0][0].ToString() == "0")
                {
                    SQLiteCommand command = new SQLiteCommand("insert into ObjectRepository (ScreenID,ObjName,ObjBy,ObjProperty,ObjDescription) values ('" + ScreenRows[1]["ScreenID"] + "', '" + ObjectName + "','" + ObjBy + "','" + ObjProp + "','" + ObjDesc + "');", conn);
                    command.ExecuteNonQuery();
                    command = null;

                }
                else { throw new Exception("Object already exists in the screen"); }

            }
            else { throw new Exception("Screen already exists " + ScreenRows.Count.ToString() + " times in the database"); }
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
                throw new Exception(e.Message);
            }

            return DT;
        }

    }
}
