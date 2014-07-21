using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace PenezniDenik
{
    class Database
    {
        static Main main_form;
        private static Database instance;
        private static String  ConnectionString = @"data source = database.db3";

        Database(){
        }
        public static Database GetInstance(Main m)
        {
            main_form = m;
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        
        }
        public static Database Instance {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
         }

        public void Refresh(){

          SQLiteConnection con = new SQLiteConnection(ConnectionString);
            SQLiteDataAdapter ada = new SQLiteDataAdapter("select * from User", con);

             DataSet ds = new DataSet() ;
             ada.Fill(ds) ;
            
             main_form.dgv.DataSource = ds.Tables[0].DefaultView;
        }

    }
}
