using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NoteBookSQLite_whitoutEF.classes
{
     class CategorieDao : NoteBookDao<Categorie>
    {
        public override void Find(int id)
        {
            var query = "SELECT * FROM Categorie WHERE Id = @id";

            var args = new Dictionary<string, object>
    {
        {"@id", id}
    };

            Execute(query, args);

         

           
        }
        public override DataTable FindAll()
        {
            var query = "SELECT * FROM Categorie";
            _ = new DataTable();
            DataTable dt = Execute(query);

            return dt;
        }
    }

}
