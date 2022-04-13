using NoteBookSQLite_whitoutEF.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NoteBookSQLite_whitoutEF
{
    class Categorie
    {
        private int idCategorie;
        private string libelleCategorie;
        public int IdCategorie { get => idCategorie; set => idCategorie=value; }
        public string LibelleCategorie { get => libelleCategorie; set => libelleCategorie=value; }
        public Categorie(int idCategorie, string libelleCategorie)
        {
            this.idCategorie=idCategorie;
            this.libelleCategorie=libelleCategorie;
        }

      
    }
}
