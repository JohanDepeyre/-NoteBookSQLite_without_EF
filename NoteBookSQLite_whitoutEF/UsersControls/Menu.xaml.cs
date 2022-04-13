using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoteBookSQLite_whitoutEF.UsersControls
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BoutonRecherche_Click(object sender, RoutedEventArgs e)
        {
            Consulter consulter = new Consulter();
            consulter.Show();

            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }
    }
}
