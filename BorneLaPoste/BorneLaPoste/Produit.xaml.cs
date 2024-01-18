using System;
using System.Windows;
using System.Windows.Controls;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Produit.xaml
    /// </summary>
    public partial class Produit : Window
    {
        public Produit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Return to the destination window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnDestinationWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open the suivi window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuiviOpen(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();
            bool isFormOpen = utils.IsAlreadyOpen(typeof(Suivi));
            if (!isFormOpen)
            {
                OrderData orderData = new OrderData { Price = 12 };

                var toto = ((Button)sender).Content.ToString();
                var titi = ((Button)sender);
                var tonto = ((Label)sender).Content.ToString();

                Suivi suiviForm = new Suivi(orderData);

                suiviForm.Owner = Application.Current.MainWindow;
                suiviForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                suiviForm.Show();
            }
        }
    }
}
