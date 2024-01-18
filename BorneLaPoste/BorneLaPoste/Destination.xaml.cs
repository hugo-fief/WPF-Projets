using System.Windows;
using BorneLaPoste.Shared;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Destination.xaml
    /// </summary>
    public partial class Destination : Window
    {
        public Destination()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Return to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnMainWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open the product window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductOpen(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();
            bool isFormOpen = utils.IsAlreadyOpen(typeof(Produit));
            if (!isFormOpen)
            {
                Produit produitForm = new Produit();

                produitForm.Owner = Application.Current.MainWindow;
                produitForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                produitForm.Show();
            }
        }
    }
}
