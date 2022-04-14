using NoteBookSQLite_whitoutEF.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NoteBookSQLite_whitoutEF.classes
{
    class Categorie
    {
        public int IdCategorie { get; set; }
        public string LibelleCategorie { get; set; }
        public Categorie(int idCategorie, string libelleCategorie)
        {
            this.IdCategorie=idCategorie;
            this.LibelleCategorie=libelleCategorie;
        }

      
    }
}
