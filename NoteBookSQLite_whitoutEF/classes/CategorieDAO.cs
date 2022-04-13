using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NoteBookSQLite_whitoutEF.classes
{
     class CategorieDAO : NoteBookDao<Categorie>
    {
        public override object find(int id)
        {
            var query = "SELECT * FROM Categorie WHERE Id = @id";

            var args = new Dictionary<string, object>
    {
        {"@id", id}
    };

            DataTable dt = base.Execute(query, args);

            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            var categorie = new Categorie(Convert.ToInt32(dt.Rows[0]["idCategorie"]), Convert.ToString(dt.Rows[0]["nomCategorie"]));
   
            return categorie;
        }

    }

}
