using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Collections.Generic;

namespace PenezniDenik
{
    class Database
    {
        String dbConnection;

        public Database()
        {

            dbConnection = "Data Source=db.s3db";

        }
        public Database(String inputFile)
        {

            dbConnection = String.Format("Data Source={0}", inputFile);

        }

        public DataTable GetDataTable(string sql)
        {

            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;

        }
        public int ExecuteNonQuery(String sql)
        {

            SQLiteConnection cnn = new SQLiteConnection(dbConnection);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
            int rowsUpdated = mycommand.ExecuteNonQuery();
            cnn.Close();
            return rowsUpdated;

        }
    }
}
