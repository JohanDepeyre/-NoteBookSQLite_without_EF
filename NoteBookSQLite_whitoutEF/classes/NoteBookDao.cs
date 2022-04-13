﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NoteBookSQLite_whitoutEF.classes
{
    public abstract class NoteBookDao<T>
    {
        private int ExecuteWrite(string query, Dictionary<string, object> args)
        {
            int numberOfRowsAffected;

            //setup the connection to the database
            using (var con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();

                //open a new command
                using (var cmd = new SQLiteCommand(query, con))
                {
                    //set the arguments given in the query
                    foreach (var pair in args)
                    {
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }

                    //execute the query and get the number of row affected
                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }

                return numberOfRowsAffected;
            }
        }
        protected DataTable Execute(string query, Dictionary<string, object> args)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using (var con = new SQLiteConnection("Data Source=test.db"))
            {
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
        }
        public abstract object find(int id);
    }
}
