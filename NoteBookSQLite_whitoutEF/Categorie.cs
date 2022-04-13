using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBookSQLite_whitoutEF
{
    class Categorie
    {
        private int idCategorie;
        private string libelleCategorie;

        public Categorie(int idCategorie, string libelleCategorie)
        {
            this.idCategorie=idCategorie;
            this.libelleCategorie=libelleCategorie;
        }
    }
}
