using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NoteBookSQLite_whitoutEF.classes;
namespace NoteBookSQLite_whitoutEF
{
    /// <summary>
    /// Logique d'interaction pour Consulter.xaml
    /// </summary>
    public partial class Consulter : Window
    {
        public Consulter()
        {
            InitializeComponent();
            List<Categorie> list = (List<Categorie>)(new CategorieDao().FindAll().AsEnumerable().ToList());
            ComboBoxCategorie.ItemsSource = new CategorieDao().FindAll().AsEnumerable().ToList() ;
            int a = 0;
        }
    }
}
