using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace NoteBookSQLite_whitoutEF
{
    class Notion
    {
        public Notion() { }

        public void ExecuteWrite()
        {
          

            //setup the connection to the database
            using (var con = new SQLiteConnection("Data Source=notebook.db"))
            {
                con.Open();


            }
        }
    }

}
