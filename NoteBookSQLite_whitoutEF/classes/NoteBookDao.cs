using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NoteBookSQLite_whitoutEF.classes
{
#pragma warning disable S2326 // Unused type parameters should be removed
    public abstract class NoteBookDao<T>
#pragma warning restore S2326 // Unused type parameters should be removed
    {
        //private int ExecuteWrite(string query, Dictionary<string, object> args)
        //{
        //    int numberOfRowsAffected;

            
        //    using (var con = new SQLiteConnection("Data Source=test.db"))
        //    {
        //        con.Open();

                
        //        using (var cmd = new SQLiteCommand(query, con))
        //        {
                   
        //            foreach (var pair in args)
        //            {
        //                cmd.Parameters.AddWithValue(pair.Key, pair.Value);
        //            }

                    
        //            numberOfRowsAffected = cmd.ExecuteNonQuery();
        //        }

        //        return numberOfRowsAffected;
        //    }
        //}
        protected DataTable Execute(string query, Dictionary<string, object> args)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using var con = new SQLiteConnection("Data Source=test.db");
            con.Open();
            using (var cmd = new SQLiteCommand(query, con))
            {
                foreach (KeyValuePair<string, object> entry in args)
                {
                    cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                }

                var da = new SQLiteDataAdapter(cmd);

                var dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
            }
        }
        /// <summary>
        /// Retourne le contenu entier d'une table 
        /// </summary>
        /// <param name="query"> requete SQL </param>
        /// <returns>Datatable contenant le contenu entier d'une table</returns>
        protected DataTable Execute(string query)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using var con = new SQLiteConnection("Data Source=notebook.db");
            con.Open();
            using var cmd = new SQLiteCommand(query, con);

            var da = new SQLiteDataAdapter(cmd);

            var dt = new DataTable();
            da.Fill(dt);

            da.Dispose();
            return dt;
        }
        public abstract void Find(int id);
        public abstract DataTable FindAll();
    }
}
